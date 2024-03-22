import { Injectable } from '@angular/core';
import { environment } from '../environments/environment';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { DocumentTypeDto, GenderDto, RaceDto, WastePickerDto } from '../shared/models/wastePicker';
import { map } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class RegistrarService {
  baseUrl = environment.apiUrl;

  constructor(private http: HttpClient) {}

  getWastePickers() {
    return this.http.get<WastePickerDto>(this.baseUrl + 'WastePicker/get-waste-pickers')
  }

  getWastePickerDetails(WastePickerId: number) {
    return this.http.get<WastePickerDto>(this.baseUrl + 'WastePicker/get-waste-picker/' + WastePickerId);
  }

  addWastePicker(data: WastePickerDto)  {
    return this.http.post<WastePickerDto>(this.baseUrl + 'WastePicker/add-waste-picker', data, {
      withCredentials: true,
      headers: new HttpHeaders({
        'Content-Type': 'application/json'
      }),
    }).pipe(map<any, any>((data) => {
      return data;
    })
    );
  }

  updateWastePicker(data: WastePickerDto)  {
    return this.http.post<WastePickerDto>(this.baseUrl + 'WastePicker/update-waste-picker', data, {
      withCredentials: true,
      headers: new HttpHeaders({
        'Content-Type': 'application/json'
      }),
    }).pipe(map<any, any>((data) => {
      return data;
    })
    );
  }

  getGender() {
    return this.http.get<GenderDto>(this.baseUrl + 'Gender/get-gender');
  }

  getetRace() {
    return this.http.get<RaceDto>(this.baseUrl + 'Race/get-race');
  }

  getDocumentType() {
    return this.http.get<DocumentTypeDto>(this.baseUrl + 'DocumentType/get-document-type' );
  }

}
