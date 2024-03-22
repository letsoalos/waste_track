import { Component, Input, OnInit } from '@angular/core';
import { FormGroup } from '@angular/forms';
import { RegistrarService } from 'src/app/registrar/registrar.service';
import { GenderDto, RaceDto, DocumentTypeDto } from 'src/app/shared/models/wastePicker';

@Component({
  selector: 'app-personal-details',
  templateUrl: './personal-details.component.html',
  styleUrls: ['./personal-details.component.scss']
})
export class PersonalDetailsComponent implements OnInit {
  @Input() addWastePickerForm?: FormGroup; 
  genders: any | GenderDto[] = [];
  races: any | RaceDto[] = [];
  documentTypes: any | DocumentTypeDto[] = [];

  constructor(private registrarService: RegistrarService) {}
  
  ngOnInit(): void {
    this.loadGender();
    this.loadRace();
    this.loadDocumentType();
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
}
