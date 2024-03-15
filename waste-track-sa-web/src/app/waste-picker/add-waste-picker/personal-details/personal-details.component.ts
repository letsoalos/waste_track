import { Component, Input, OnInit } from '@angular/core';
import { FormGroup } from '@angular/forms';
import { DocumentTypeDto, GenderDto, RaceDto } from 'src/app/shared/models/wastePicker';
import { WastePickerService } from '../../waste-picker.service';

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

  constructor(private wastePickerService: WastePickerService) {}
  
  ngOnInit(): void {
    this.loadGender();
    this.loadRace();
    this.loadDocumentType();
  }

    loadGender(): void {
      this.wastePickerService.getGender().subscribe({
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
    this.wastePickerService.getetRace().subscribe({
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
    this.wastePickerService.getDocumentType().subscribe({
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

