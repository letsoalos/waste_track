import { ElementRef, Injectable, ViewChild } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class CameraService {
  @ViewChild('video') videoElement!: ElementRef;
  @ViewChild('canvas') canvasElement!: ElementRef;

  video: any | HTMLVideoElement;
  canvas: any | HTMLCanvasElement;
  photo: any | HTMLImageElement;
  showRetakeBtn: boolean = false;
  capturedImages: string[] = [];
  rearCamera: boolean = true;
  isCameraOn: boolean = false;


  constructor() {}

   // Function to switch camera
   switchCamera() {
    this.isCameraOn = !this.isCameraOn;
    if (this.isCameraOn) {
        // Start the camera if it's switched on
        this.startCamera();
    } else {
        // Stop the camera if it's switched off
        this.stopCamera();
    }
}

stopCamera() {
  // Logic to stop the camera (e.g., stop video stream)
  // For example, if you're using HTMLMediaElement for video:
  const videoElement = document.querySelector('video');
  const mediaStream = videoElement!.srcObject as MediaStream;
  const tracks = mediaStream.getTracks();
  tracks.forEach(track => track.stop());
  videoElement!.srcObject = null;
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
  
    if (this.capturedImages.length < 3) {
      this.capturedImages.push(imageDataUrl);
    } else {
      console.log('Maximum limit reached.'); // Log a message if the maximum limit is reached
    }
  }

  // Inside your component class
retakePhoto(index: number): void {
  this.capturedImages.splice(index, 1);
}
}
