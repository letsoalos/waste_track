import { Component, Input, OnInit } from '@angular/core';
import { FormGroup } from '@angular/forms';
import { RegistrarService } from 'src/app/registrar/registrar.service';
import { MunicipalityDto } from 'src/app/shared/models/municipality';
import { PaymetTypeDto } from 'src/app/shared/models/paymentType';
import { SortingAreaDto } from 'src/app/shared/models/sortingArea';
import { WorkSiteDto } from 'src/app/shared/models/workSite';

@Component({
  selector: 'app-collection-info',
  templateUrl: './collection-info.component.html',
  styleUrls: ['./collection-info.component.scss']
})
export class CollectionInfoComponent implements OnInit {
  @Input() addWastePickerForm!: FormGroup;  
  
  municipalities: any | MunicipalityDto[] = [];
  workSites: any | WorkSiteDto[] = [];
  sortingAreas: any | SortingAreaDto[] = [];
  paymentTypes: any | PaymetTypeDto [] = [];

  constructor(private registrarService: RegistrarService){}


  ngOnInit(): void {
    this.loadMunicipality();
    this.loadPaymentType();
    this.loadSortingArea();
    this.loadWorkSite();
  }

  loadMunicipality(): void {
    this.registrarService.getMunicipality().subscribe({
      next: (res) => { 
        console.log(res);
        this.municipalities = res;
      },
      error: (err) => {
        console.log(err);
      }
    });
  }

  loadWorkSite(): void {
    this.registrarService.getWorkSite().subscribe({
      next: (res) => { 
        console.log(res);
        this.workSites = res;
      },
      error: (err) => {
        console.log(err);
      }
    });
  }

  loadPaymentType(): void {
    this.registrarService.getPaymentType().subscribe({
      next: (res) => { 
        console.log(res);
        this.paymentTypes = res;
      },
      error: (err) => {
        console.log(err);
      }
    });
  }

  loadSortingArea(): void {
    this.registrarService.getSortingArea().subscribe({
      next: (res) => { 
        console.log(res);
        this.sortingAreas = res;
      },
      error: (err) => {
        console.log(err);
      }
    });
  }

}
