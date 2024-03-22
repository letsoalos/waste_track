import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { RegistrarRoutingModule } from './registrar-routing.module';
import { RgWastePickerComponent } from './rg-waste-picker/rg-waste-picker.component';
import { RgCooperateComponent } from './rg-cooperate/rg-cooperate.component';
import { RgHomeComponent } from './rg-home/rg-home.component';
import { ReactiveFormsModule } from '@angular/forms';
import { AgGridModule } from 'ag-grid-angular';

@NgModule({
  declarations: [
    RgWastePickerComponent,
    RgCooperateComponent,
    RgHomeComponent
  ],
  imports: [
    CommonModule,
    RegistrarRoutingModule,
    AgGridModule,
    ReactiveFormsModule
  ]
})
export class RegistrarModule { }
