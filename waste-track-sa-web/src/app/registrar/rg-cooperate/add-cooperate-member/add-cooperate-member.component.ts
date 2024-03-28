import { Component } from '@angular/core';
import { FormBuilder, Validators } from '@angular/forms';

@Component({
  selector: 'app-add-cooperate-member',
  templateUrl: './add-cooperate-member.component.html',
  styleUrls: ['./add-cooperate-member.component.scss']
})
export class AddCooperateMemberComponent {
  constructor(private fb: FormBuilder) {}

  addWastePickerForm = this.fb.group({
    personalDetailsForm: this.fb.group({
      firstName: ['', Validators.required],
      lastName: ['', Validators.required],
      identityNumber: ['', Validators.nullValidator],
      otherIdentityNumber: ['', Validators.nullValidator],
      dob: ['', Validators.required],
      age: ['', Validators.required],
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
