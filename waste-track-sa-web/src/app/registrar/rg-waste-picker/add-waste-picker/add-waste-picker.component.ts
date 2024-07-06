import { Component, OnInit, ViewChild } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { RegistrarService } from '../../registrar.service';
import { DatePipe } from '@angular/common'; 
import { CdkStepper } from '@angular/cdk/stepper';

@Component({
  selector: 'app-add-waste-picker',
  templateUrl: './add-waste-picker.component.html',
  styleUrls: ['./add-waste-picker.component.scss']
})
export class AddWastePickerComponent implements OnInit {
  @ViewChild(CdkStepper) stepper!: CdkStepper;
  
  addWastePickerForm: FormGroup | any;

  constructor(private fb: FormBuilder, 
              private registrarService: RegistrarService, 
             
              private datePipe: DatePipe) {}

  ngOnInit(): void {   
      this.initializeForm();   
  }

  initializeForm(): void {
    const defaultDob = new Date();

    this.addWastePickerForm = this.fb.group({
      personalDetailsForm: this.fb.group({
        firstName: ['', Validators.required],
        lastName: ['', Validators.required],
        identityNumber: ['', Validators.nullValidator],
        otherIdentityNumber: ['', Validators.nullValidator],
        dob: [defaultDob, Validators.required],
        age: ['', Validators.nullValidator],
        gender: ['', Validators.required],
        race: ['', Validators.required],
        documentType: ['', Validators.required],
        cellphoneNo: ['', Validators.nullValidator],
        altCellphoneNo: ['', Validators.nullValidator],
      }),
      collectionDetailsForm: this.fb.group({
        paymentType: ['', Validators.required],
        sortingArea: ['', Validators.required],
        municipality: ['', Validators.required],
        workSite: ['', Validators.required],
        district: ['', Validators.nullValidator],
        province: [''],
        address: ['', Validators.nullValidator],
        cooperativeId: ['', Validators.nullValidator] // assuming cooperativeId is part of collectionDetailsForm
      })
    });
  }

  calculateAge(birthday: Date): number {
    const ageDifMs = Date.now() - birthday.getTime();
    const ageDate = new Date(ageDifMs); // milliseconds from epoch
    return Math.abs(ageDate.getUTCFullYear() - 1970);
  }
}
