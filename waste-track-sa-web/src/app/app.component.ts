import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { WastePickerDto, WastePickerStatusDto } from './models/wastePicker';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent implements OnInit {
  title = 'waste-track';
  wastePickers: any | WastePickerDto[] = [];

  constructor(private http: HttpClient) {}

  ngOnInit(): void {
    this.http.get<WastePickerStatusDto[]>('https://localhost:5001/api/WastePicker/get-waste-pickers?pageSize=50').subscribe({
      next: response => this.wastePickers = response,
      error: error => console.log(error),
      complete: () => {
        console.log('request completed');
      }
    })
  }
 
}
