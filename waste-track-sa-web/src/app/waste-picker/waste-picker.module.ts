import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { WastePickerListComponent } from './waste-picker-list/waste-picker-list.component';
import { EditWastePickerComponent } from './edit-waste-picker/edit-waste-picker.component';
import { WastePickerDetailsComponent } from './waste-picker-details/waste-picker-details.component';
import { AgGridModule } from 'ag-grid-angular';
import { ModalModule } from 'ngx-bootstrap/modal'
import { ReactiveFormsModule } from '@angular/forms';
import { SharedModule } from '../shared/shared.module';
import { NgxExtendedPdfViewerServerModule } from 'ngx-extended-pdf-viewer';
import { WastePickerRoutingModule } from './waste-picker-routing.module';



@NgModule({
  declarations: [
    WastePickerListComponent,
    EditWastePickerComponent,
    WastePickerDetailsCompon
     
  ],
  imports: [
    CommonModule,
    AgGridModule,
    ReactiveFormsModule,
    SharedModule,
    NgxExtendedPdfViewerServerModule,
    WastePickerRoutingModule,
    ModalModule.forRoot()
  ]
})
export class WastePickerModule { }
