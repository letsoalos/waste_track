import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { WastePickerListComponent } from './waste-picker-list/waste-picker-list.component';
import { EditWastePickerComponent } from './edit-waste-picker/edit-waste-picker.component';
import { AddWastePickerComponent } from './add-waste-picker/add-waste-picker.component';
import { WastePickerDetailsComponent } from './waste-picker-details/waste-picker-details.component';
import { AgGridModule } from 'ag-grid-angular';
import { ModalModule } from 'ngx-bootstrap/modal'
import { ReactiveFormsModule } from '@angular/forms';
import { RouterModule } from '@angular/router';
import { SharedModule } from '../shared/shared.module';
import { ContactDetailsComponent } from './add-waste-picker/contact-details/contact-details.component';
import { PersonalDetailsComponent } from './add-waste-picker/personal-details/personal-details.component';
import { TextInputComponent } from '../shared/components/text-input/text-input.component';



@NgModule({
  declarations: [
    WastePickerListComponent,
    EditWastePickerComponent,
    AddWastePickerComponent,
    WastePickerDetailsComponent,
    ContactDetailsComponent,
    PersonalDetailsComponent,
    TextInputComponent
  ],
  imports: [
    CommonModule,
    AgGridModule,
    ReactiveFormsModule,
    RouterModule,
    SharedModule,
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
