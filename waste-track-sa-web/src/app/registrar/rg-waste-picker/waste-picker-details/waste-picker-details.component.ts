import { Component, OnInit } from '@angular/core';
import { WastePickerDto } from 'src/app/shared/models/wastePicker';
import { RegistrarService } from '../../registrar.service';
import { ActivatedRoute } from '@angular/router';
import { EditWastePickerComponent } from '../edit-waste-picker/edit-waste-picker.component';
import { BsModalService } from 'ngx-bootstrap/modal';

@Component({
  selector: 'app-waste-picker-details',
  templateUrl: './waste-picker-details.component.html',
  styleUrls: ['./waste-picker-details.component.scss']
})
export class WastePickerDetailsComponent implements OnInit {
  wastePickerId: any | number;
  wastePicker: WastePickerDto | null = null;
  bsModalRef: any;

  constructor(
    private route: ActivatedRoute,
    private registrarService: RegistrarService,
    private modalService: BsModalService
  ) {}

  ngOnInit(): void {
    this.route.paramMap.subscribe(params => {
        const id = params.get('id');
        console.log('Waste Picker ID:', id);
        this.wastePickerId = id ? parseInt(id, 10) : null;
        console.log('Waste Picker ID (parsed):', this.wastePickerId);
        if (isNaN(this.wastePickerId)) {
            console.log('Invalid Waste Picker ID');
            // Handle invalid ID here (e.g., navigate to an error page)
        } else {
            // Proceed with loading the waste picker data
            this.loadWastePicker(this.wastePickerId);
        }
    });
}

  loadWastePicker(id: number): void {
    this.registrarService.getWastePickerDetails(id).subscribe({
      next: (res) => {
        console.log('Waste Picker Details Response:', res); // Log the response
        this.wastePicker = res;
      },
      error: (err) => {
        console.error('Error fetching waste picker details:', err); // Log any errors
      }
    });
  }

    updateWastePicker(action: string, data: WastePickerDto) {
      const model = data;
      const userAction = action;
      const config = {
      keyboard: false,
      backdrop: true,
      ignoreBackdropClick: true,
      class: 'modal-dialog-centered modal-lg',
      initialState: { model, userAction }
      };
        this.bsModalRef = this.modalService.show(EditWastePickerComponent, config);
        this.bsModalRef.content.updateModel.subscribe((m: any) => {});
        //this.wastePickerService.addFleet(m).subscribe({
       // next: res => {
       //   this.toastr.success('Saved successfully', 'Success');
       // },
       // error: err => {
       //   console.log(err);
        //  this.toastr.error('Something went wrong, try again', 'Error');
        
       // });
    //});
  }
}

function updateWastePicker(action: any, string: any, data: any, WastePickerDto: any) {
  throw new Error('Function not implemented.');
}

