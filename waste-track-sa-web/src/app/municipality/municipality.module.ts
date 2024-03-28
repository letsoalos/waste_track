import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { MunicipalityRoutingModule } from './municipality-routing.module';
import { MuHomeComponent } from './mu-home/mu-home.component';
import { AgGridModule } from 'ag-grid-angular';
import { ReactiveFormsModule } from '@angular/forms';


@NgModule({
  declarations: [
    MuHomeComponent
  ],
  imports: [
    CommonModule,
    MunicipalityRoutingModule,
    ReactiveFormsModule,   
    AgGridModule,
    
  ]
})
export class MunicipalityModule { }
