import { Component, ElementRef, Input, OnInit, ViewChild } from '@angular/core';
import { RegistrarService } from 'src/app/registrar/registrar.service';
import { FormGroup } from '@angular/forms';
import { ToastrService } from 'ngx-toastr';

@Component({
  selector: 'app-supporting-docs',
  templateUrl: './supporting-docs.component.html',
  styleUrls: ['./supporting-docs.component.scss']
})
export class SupportingDocsComponent implements OnInit {
  @ViewChild('video') videoElement!: ElementRef;
  @ViewChild('canvas') canvasElement!: ElementRef;
  @Input() addWastePickerForm: FormGroup | any; 

  capturedImages: string[] = [];
  isCameraOn: boolean = false;
  datePipe: any;

  constructor(private registrarService: RegistrarService,
              private toastr: ToastrService) {}

  ngOnInit(): void {
    console.log('addWastePickerForm:', this.addWastePickerForm);
  }

  toggleCamera() {
    if (this.isCameraOn) {
      this.takePhoto();
    } else {
      this.switchCamera();
    }
  }

  switchCamera() {
    this.isCameraOn = !this.isCameraOn;
    if (this.isCameraOn) {
      this.startCamera();
    } else {
      this.stopCamera();
    }
  }

  stopCamera() {
    const videoElement = this.videoElement.nativeElement;
    const mediaStream = videoElement.srcObject as MediaStream;
    const tracks = mediaStream.getTracks();
    tracks.forEach(track => track.stop());
    videoElement.srcObject = null;
  }

  startCamera() {
    const video = this.videoElement.nativeElement;
    const constraints = {
      video: true
    };

    navigator.mediaDevices.getUserMedia(constraints)
      .then((stream) => {
        video.srcObject = stream;
      })
      .catch((err) => {
        console.error('Error accessing camera: ', err);
      });
  }

  takePhoto() {
    const video = this.videoElement.nativeElement;
    const canvas = this.canvasElement.nativeElement;
    const context = canvas.getContext('2d');
    
    canvas.width = video.videoWidth;
    canvas.height = video.videoHeight;
    context.drawImage(video, 0, 0, canvas.width, canvas.height);
  
    const imageDataUrl = canvas.toDataURL('image/png');
    console.log('Image captured:', imageDataUrl);
  
    if (this.capturedImages.length < 3) {
      this.capturedImages.push(imageDataUrl);
    } else {
      console.log('Maximum limit reached.');
    }
  }

  retakePhoto(index: number): void {
    this.capturedImages.splice(index, 1);
  }

  addWastePicker() {
    
    try {
      console.log('Form validity:', this.addWastePickerForm.valid);
      //console.log('Personal Details Form:', personalDetailsForm.value);

      if (!this.addWastePickerForm || !this.addWastePickerForm.valid) {
        console.error('Form is invalid. Form contents:', this.addWastePickerForm.value);
        return;
      }
  
      const personalDetailsForm = this.addWastePickerForm.get('personalDetailsForm');
      const dobValue = personalDetailsForm.get('dob').value;
  
      if (dobValue === null || dobValue === undefined) {
        throw new Error('Date of birth is missing.');
      }
  
      // Format date only if dobValue is not null or undefined
      const formattedDobString = this.datePipe.transform(dobValue, 'yyyy-MM-dd');
      const formattedDob = formattedDobString as string; // Assert to string
      const ageValue = this.calculateAge(new Date(dobValue));
  
      const collectionDetailsForm = this.addWastePickerForm.get('collectionDetailsForm');
  
      const formData = {
        id: 0,
        firstName: personalDetailsForm.get('firstName').value,
        lastName: personalDetailsForm.get('lastName').value,
        dob: formattedDob,
        identityNumber: personalDetailsForm.get('identityNumber').value,
        otherIdentityNumber: personalDetailsForm.get('otherIdentityNumber').value || 'NULL',
        age: ageValue,
        cellphoneNo: personalDetailsForm.get('cellphoneNo').value,
        altCellphoneNo: personalDetailsForm.get('altCellphoneNo').value,
        potrait: '',
        documentTypeId: personalDetailsForm.get('documentType').value,
        wastePickerNo: 0,
        comment: null,
        consent: 0,
        createdBy: "sello@test.com",
        createdDate: "2024/03/30",
        lastUpdatedBy: "sello@test.com",
        lastUpdatedDate: "2024/03/30",
        registrationLocation: "Sandton",
        raceId: personalDetailsForm.get('race').value,
        isMemberCooperative: true,
        activityStatusId: 2,
        lastActivityDate: "2024/03/30",
        printCount: 0,
        manualPrintCount: 0,
        autoPrintCount: 0,
        documentType: personalDetailsForm.get('documentType').value,
        genderId: personalDetailsForm.get('gender').value,
        cooperativeId: collectionDetailsForm.get('cooperativeId').value,
        wastePickerStatus: "Updated",
        gender: personalDetailsForm.get('gender').value,
        race: personalDetailsForm.get('race').value,
        cooperative: collectionDetailsForm.get('cooperative').value
      };
  
      console.log('FormData:', formData); // Log the form data
  
      this.registrarService.addWastePicker(formData).subscribe({
        next: (response) => {
          console.log('Record added successfully:', response);
          this.toastr.success('Saved successfully', 'Success');
          // Reset the form after successful submission
          this.addWastePickerForm.reset();
          this.capturedImages = []; // Reset captured images
        },
        error: (error) => {
          console.error('Error occurred while adding record:', error);
          this.toastr.error('Something went wrong, try again', 'Error');
        }
      });
    } catch (error) {
      console.log(error);
    }
  }
  

  calculateAge(birthday: Date): number {
    const today = new Date();
    const dobDate = new Date(birthday);
    let age = today.getFullYear() - dobDate.getFullYear();
    const monthDiff = today.getMonth() - dobDate.getMonth();
    if (monthDiff < 0 || (monthDiff === 0 && today.getDate() < dobDate.getDate())) {
      age--;
    }
    return age;
  }
}


  /*submitForm(): void {   

    if (this.addWastePickerForm && this.addWastePickerForm.valid) {
      const personalDetailsForm = this.addWastePickerForm.get('personalDetailsForm');
      const dobValue = personalDetailsForm.get('dob').value;
      
      if (dobValue !== null && dobValue !== undefined) {
        // Format date only if dobValue is not null or undefined
        const formattedDobString = this.datePipe.transform(dobValue, 'yyyy-MM-dd');
        const formattedDob = formattedDobString as string; // Assert to string
        const ageValue = this.calculateAge(new Date(dobValue));
  
        // Define collectionDetailsForm here
        const collectionDetailsForm = this.addWastePickerForm.get('collectionDetailsForm');
    
        const formData = {
          id: 0,
          firstName: personalDetailsForm.get('firstName').value,
          lastName: personalDetailsForm.get('lastName').value,
          dob: formattedDob,
          identityNumber: personalDetailsForm.get('identityNumber').value,
          otherIdentityNumber: personalDetailsForm.get('otherIdentityNumber').value || 'NULL',
          age: ageValue,
          cellphoneNo: personalDetailsForm.get('cellphoneNo').value,
          altCellphoneNo: personalDetailsForm.get('altCellphoneNo').value,
          potrait: '', 
          documentTypeId: personalDetailsForm.get('documentType').value,
          wastePickerNo: 0,
          comment: null,
          consent: 0,
          createdBy: "sello@test.com",
          createdDate: "2024/03/30",
          lastUpdatedBy: "sello@test.com",
          lastUpdatedDate: "2024/03/30",
          registrationLocation: "Sandton",
          raceId: personalDetailsForm.get('race').value,
          isMemberCooperative: true,
          activityStatusId: 2,
          lastActivityDate: "2024/03/30",
          printCount: 0,
          manualPrintCount: 0,
          autoPrintCount: 0,
          documentType: personalDetailsForm.get('documentType').value,
          genderId: personalDetailsForm.get('gender').value,
          cooperativeId: collectionDetailsForm.get('cooperativeId').value,
          wastePickerStatus: "Updated",
          gender: personalDetailsForm.get('gender').value,
          race: personalDetailsForm.get('race').value,
          cooperative: collectionDetailsForm.get('cooperative').value
        };
  
        console.log('Form is valid.'); 
    
        this.registrarService.addWastePicker(formData).subscribe({
          next: (response) => {
            console.log('Record added successfully:', response);
            this.addWastePickerForm.reset();
          },
          error: (error) => {
            console.error('Error occurred while adding record:', error);
          }
        });

        console.log('onSubmit() method called.');
      
      }
    }
  }
  calculateAge(birthday: Date): number {
    const today = new Date();
    const dobDate = new Date(birthday);
    let age = today.getFullYear() - dobDate.getFullYear();
    const monthDiff = today.getMonth() - dobDate.getMonth();
    if (monthDiff < 0 || (monthDiff === 0 && today.getDate() < dobDate.getDate())) {
      age--;
    }
    return age;
  }*/
  
//}
