import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { WastePickerListComponent } from './waste-picker-list/waste-picker-list.component';
import { EditWastePickerComponent } from './edit-waste-picker/edit-waste-picker.component';
import { AddWastePickerComponent } from './add-waste-picker/add-waste-picker.component';
import { WastePickerDetailsComponent } from './waste-picker-details/waste-picker-details.component';
import { AgGridModule } from 'ag-grid-angular';
import { ModalModule } from 'ngx-bootstrap/modal'



@NgModule({
  declarations: [
    WastePickerListComponent,
    EditWastePickerComponent,
    AddWastePickerComponent,
    WastePickerDetailsComponent
  ],
  imports: [
    CommonModule,
    AgGridModule,
    ModalModule.forRoot()
  ],
  exports: [
    WastePickerListComponent,
    EditWastePickerComponent,
    AddWastePickerComponent,
    WastePickerDetailsComponent
  ]
})
export class WastePickerModule { }
