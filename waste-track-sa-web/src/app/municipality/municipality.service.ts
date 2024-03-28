import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { environment } from '../environments/environment';
import { MunicipalityDto } from '../shared/models/municipality';

@Injectable({
  providedIn: 'root'
})
export class MunicipalityService {
  baseUrl = environment.apiUrl;

  constructor(private http: HttpClient) {}

  getMunicipality() {
    return this.http.get<MunicipalityDto[]>(this.baseUrl + 'Municipality/get-municipalities');
  }

}
