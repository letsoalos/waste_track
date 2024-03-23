import { Component, ElementRef, Input, OnInit, ViewChild } from '@angular/core';
import { FormGroup } from '@angular/forms';
import { RegistrarService } from 'src/app/registrar/registrar.service';
import { CameraService } from 'src/app/shared/camera.service';
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
  video: any | HTMLVideoElement;
  canvas: any | HTMLCanvasElement;
  photo: any | HTMLImageElement;
  showRetakeBtn: boolean = false;
  capturedImages: string[] = [];
  rearCamera: boolean = true;
  cameraEnabled: any;


  constructor(private registrarService: RegistrarService, private cameraService: CameraService) {}
  
  ngOnInit(): void {
    this.loadGender();
    this.loadRace();
    this.loadDocumentType();
    this.cameraService.startCamera();
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

  // Function to switch camera
  switchCamera() {
    this.rearCamera = !this.rearCamera;
    this.startCamera();
  }

  startCamera() {
    const video = this.videoElement.nativeElement;
    const constraints = {
      video: {
        facingMode: this.rearCamera ? 'environment' : 'user'
      }
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
    console.log('Image captured:', imageDataUrl); // Log the captured image data URL
  
    if (this.capturedImages.length < 4) {
      this.capturedImages.push(imageDataUrl);
    } else {
      console.log('Maximum limit reached.'); // Log a message if the maximum limit is reached
    }
  }
}

