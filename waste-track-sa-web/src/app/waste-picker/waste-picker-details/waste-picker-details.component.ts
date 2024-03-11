import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { BsModalRef, BsModalService } from 'ngx-bootstrap/modal';
import { WastePickerDto } from 'src/app/shared/models/wastePicker';
import { WastePickerService } from '../waste-picker.service';
import { EditWastePickerComponent } from '../edit-waste-picker/edit-waste-picker.component';

@Component({
  selector: 'app-waste-picker-details',
  templateUrl: './waste-picker-details.component.html',
  styleUrls: ['./waste-picker-details.component.scss']
})
export class WastePickerDetailsComponent implements OnInit {

  wastePickerId: any | number;
  wastePicker: WastePickerDto | null = null;
  bsModalRef?: BsModalRef

  constructor(
    private modalService: BsModalService,
    private route: ActivatedRoute,
    private wastePickerService: WastePickerService
  ) {}

  ngOnInit(): void {
    this.route.queryParamMap.subscribe((params: any) => {
      this.wastePickerId = +params.get('id'); // Convert to number
    });
    this.loadWastePicker(this.wastePickerId);
  }

  loadWastePicker(v: number): void {
    this.wastePickerService.getWastePickerDetails(v).subscribe({
      next: (res) => {
        console.log(res);
        this.wastePicker = res;
      },
      error: (err) => {
        console.log(err);
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
            