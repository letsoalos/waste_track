import { Component } from '@angular/core';
import { FormBuilder, Validators } from '@angular/forms';

@Component({
  selector: 'app-add-waste-picker',
  templateUrl: './add-waste-picker.component.html',
  styleUrls: ['./add-waste-picker.component.scss']
})
export class AddWastePickerComponent {
  constructor(private fb: FormBuilder) {}

  addWastePickerForm = this.fb.group({
    personalDetailsForm: this.fb.group({
      firstName: ['', Validators.required],
      lastName: ['', Validators.required],
      identityNumber: ['', Validators.nullValidator],
      otherIdentityNumber: ['', Validators.nullValidator],
      dob: ['', Validators.required],
      age: ['', Validators.nullValidator],
      gender: ['', Validators.required],
      race: ['', Validators.required],
      documentType: ['', Validators.required],
      cellphoneNo: ['', Validators.nullValidator],
      altCellphoneNo: ['', Validators.nullValidator],
    }),
    collectionDetailsForm : this.fb.group({
      noOfYears: ['', Validators.required],
      paymentType: ['', Validators.required],
      sortingArea: ['', Validators.required],
      municipality: ['', Validators.required],
      workSite: ['', Validators.required],
      district: ['', Validators.nullValidator],
      province: ['',],
      address: ['', Validators.nullValidator]
    }) 
  });
 
}
