import { NgModule } from '@angular/core';
import { AddWastePickerComponent } from './add-waste-picker.component';
import { AddWastePickerRoutingModule } from './add-waste-picker-routing.module';
import { SharedModule } from 'src/app/shared/shared.module';
import { TextInputComponent } from 'src/app/shared/components/text-input/text-input.component';
import { PersonalDetailsComponent } from './personal-details/personal-details.component';
import { ConsentDocsComponent } from './consent-docs/consent-docs.component';
import { SupportingDocsComponent } from './supporting-docs/supporting-docs.component';
import { CollectionInfoComponent } from './collection-info/collection-info.component';
import { CommonModule } from '@angular/common';



@NgModule({
  declarations: [
    AddWastePickerComponent,
    PersonalDetailsComponent,
    ConsentDocsComponent,
    CollectionInfoComponent,
    SupportingDocsComponent,  
    TextInputComponent
  ],
  imports: [
    SharedModule,
    CommonModule,
    AddWastePickerRoutingModule
  ]
})
export class AddWastePickerModule { }
