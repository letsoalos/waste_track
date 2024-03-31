import { Component, ElementRef, ViewChild } from '@angular/core';

@Component({
  selector: 'app-supporting-docs',
  templateUrl: './supporting-docs.component.html',
  styleUrls: ['./supporting-docs.component.scss']
})
export class SupportingDocsComponent {
  @ViewChild('video') videoElement!: ElementRef;
  @ViewChild('canvas') canvasElement!: ElementRef;

  capturedImages: string[] = [];
  isCameraOn: boolean = false;

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
  

}
