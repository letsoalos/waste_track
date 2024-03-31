import { Component, ElementRef, Input, OnInit, ViewChild } from '@angular/core';
import { FormGroup } from '@angular/forms';
import { RegistrarService } from 'src/app/registrar/registrar.service';
import { GenderDto, RaceDto, DocumentTypeDto } from 'src/app/shared/models/wastePicker';

@Component({
  selector: 'app-personal-details',
  templateUrl: './personal-details.component.html',
  styleUrls: ['./personal-details.component.scss']
})
export class PersonalDetailsComponent implements OnInit {
  @Input() addWastePickerForm!: FormGroup; 
  @ViewChild('video') videoElement!: ElementRef;
  @ViewChild('canvas') canvasElement!: ElementRef;
  
  genders: any | GenderDto[] = [];
  races: any | RaceDto[] = [];
  documentTypes: any | DocumentTypeDto[] = [];
  capturedImage: string | undefined;
  isCameraOn: boolean = false;

  constructor(private registrarService: RegistrarService) {}
  
  ngOnInit(): void {
    this.loadGender();
    this.loadRace();
    this.loadDocumentType();
    // Calculate age initially
    this.calculateAgeOnLoad();
  }

  loadGender(): void {
    this.registrarService.getGender().subscribe({
      next: (res) => {
        console.log(res);
        this.genders = res;
      },
      error: (err) => {
        console.log(err);
      }
    });
  }

  loadRace(): void {
    this.registrarService.getetRace().subscribe({
      next: (res) => { 
        console.log(res);
        this.races = res;
      },
      error: (err) => {
        console.log(err);
      }
    });
  }

  loadDocumentType(): void {
    this.registrarService.getDocumentType().subscribe({
      next: (res) => { 
        console.log(res);
        this.documentTypes = res;
      },
      error: (err) => {
        console.log(err);
      }
    });
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
    // Logic to stop the camera
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
  
    // Save captured image in base64 format
    this.capturedImage = canvas.toDataURL('image/png');
    console.log('Image captured:', this.capturedImage);
  }

  retakePhoto() {
    // Clear the captured image
    this.capturedImage = undefined;
  }

  calculateAgeOnLoad() {
    const dobControl = this.addWastePickerForm.get('personalDetailsForm.dob');
    if (dobControl && dobControl.value) {
      const dob = new Date(dobControl.value);
      const age = this.calculateAge(dob);
      this.addWastePickerForm.get('personalDetailsForm.age')?.setValue(age);
    }
  }

  calculateAge(dob: Date): number {
    const today = new Date();
    const dobDate = new Date(dob);
    let age = today.getFullYear() - dobDate.getFullYear();
    const monthDiff = today.getMonth() - dobDate.getMonth();
    if (monthDiff < 0 || (monthDiff === 0 && today.getDate() < dobDate.getDate())) {
      age--;
    }
    return age;
  }
}
