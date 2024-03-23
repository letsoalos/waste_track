import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class CameraService {

  video: any | HTMLVideoElement;
  canvas: any | HTMLCanvasElement;

  constructor() {}

  startCamera() {
    this.video = document.createElement('video');
    this.canvas = document.createElement('canvas');
    navigator.mediaDevices.getUserMedia({ video: true })
      .then(stream => {
        this.video.srcObject = stream;
      })
      .catch(err => {
        console.error('Error accessing camera: ', err);
      });
  }

  takePhoto(): string {
    const context = this.canvas.getContext('2d');
    context.drawImage(this.video, 0, 0, this.canvas.width, this.canvas.height);
    return this.canvas.toDataURL('image/png');
  }
}
