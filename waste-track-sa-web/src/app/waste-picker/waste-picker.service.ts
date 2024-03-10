import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { WastePickerDto } from '../shared/models/wastePicker';

@Injectable({
  providedIn: 'root'
})
export class WastePickerService {
  baseUrl = 'https://localhost:5001/api/'; 

  constructor(private http: HttpClient) { }

  getWastePickers() {
    return this.http.get<WastePickerDto[]>(this.baseUrl + 'WastePicker/get-waste-pickers');
  }
}
