import { Component, EventEmitter, OnInit, Output } from '@angular/core';
import { FormBuilder, FormGroup } from '@angular/forms';
import { WastePickerService } from '../waste-picker.service';
import { BsModalRef } from 'ngx-bootstrap/modal';
import { WastePickerDto } from 'src/app/shared/models/wastePicker';

@Component({
  selector: 'app-edit-waste-picker',
  templateUrl: './edit-waste-picker.component.html',
  styleUrls: ['./edit-waste-picker.component.scss']
})
export class EditWastePickerComponent implements OnInit {
  form: FormGroup | any
  model: any;
  userAction?: string;
  wastePickers: WastePickerDto[] = []

  @Output() updateModel = new EventEmitter<any>();

  constructor(private fb: FormBuilder,
      private wastePickerService: WastePickerService,
      private bsModelRef: BsModalRef) {}


  ngOnInit(): void {
    this.getForm();
    if (this.userAction === 'update') {
      this.form?.setValue({
      firstName: this.model.firstName,
      lastName: this.model.lastName,
      dob: this.model.dob,
      identityNumber: this.model.identityNumber,
      otherIdentityNumber: this.model.otherIdentityNumber,
      age: this.model.age,
      cellphoneNo: this.model.cellphoneNo,
      altCellphoneNo: this.model.altCellphoneNo,
      documentType: this.model.documentType,
      comment: this.model.comment,
      registrationLocation: this.model.registrationLocation,
      gender: this.model.gender,
      race: this.model.race,
      cooperative: this.model.cooperative,
      isMemberCooperative: this.model.isMemberCooperative,
      wastePickerStatus: this.model.wastePickerStatus,
      });
      this.getForm();
    }
  }

  getForm(): any {
    this.form = this.fb.group({
      firstName: this.model.firstName,
      lastName: this.model.lastName,
      dob: this.model.dob,
      identityNumber: this.model.identityNumber,
      otherIdentityNumber: this.model.otherIdentityNumber,
      age: this.model.age,
      cellphoneNo: this.model.cellphoneNo,
      altCellphoneNo: this.model.altCellphoneNo,
      documentType: this.model.documentType,
      comment: this.model.comment,
      registrationLocation: this.model.registrationLocation,
      gender: this.model.gender,
      race: this.model.race,
      cooperative: this.model.cooperative,
      isMemberCooperative: this.model.isMemberCooperative,
      wastePickerStatus: this.model.wastePickerStatus,
    });
  }

  get formControls() { return this.form?.controls; }

  closeModal(): void  {
    this.bsModelRef.hide();
  }

  onSubmit(): void  {
    this.updateModel.emit(this.form?.value);
    this.bsModelRef.hide();
  }

}
