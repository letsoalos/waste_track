import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RegistrarRoutingModule } from './registrar-routing.module';
import { RgWastePickerComponent } from './rg-waste-picker/rg-waste-picker.component';
import { RgCooperateComponent } from './rg-cooperate/rg-cooperate.component';
import { RgHomeComponent } from './rg-home/rg-home.component';
import { ReactiveFormsModule } from '@angular/forms';
import { AgGridModule } from 'ag-grid-angular';
import { WastePickerDetailsComponent } from './rg-waste-picker/waste-picker-details/waste-picker-details.component';
import { ModalModule } from 'ngx-bootstrap/modal';
import { EditWastePickerComponent } from './rg-waste-picker/edit-waste-picker/edit-waste-picker.component';
import { AddWastePickerComponent } from './rg-waste-picker/add-waste-picker/add-waste-picker.component';
import { SharedModule } from "../shared/shared.module";
import { ConsentDocsComponent } from './rg-waste-picker/add-waste-picker/consent-docs/consent-docs.component';
import { PersonalDetailsComponent } from './rg-waste-picker/add-waste-picker/personal-details/personal-details.component';
import { TextInputComponent } from '../shared/components/text-input/text-input.component';
import { CollectionInfoComponent } from './rg-waste-picker/add-waste-picker/collection-info/collection-info.component';
import { SupportingDocsComponent } from './rg-waste-picker/add-waste-picker/supporting-docs/supporting-docs.component';
import { MatButtonModule } from '@angular/material/button';
import { MatInputModule } from '@angular/material/input';
import { MatSelectModule } from '@angular/material/select';
import { MatIconModule } from '@angular/material/icon';
import { MatCheckboxModule } from '@angular/material/checkbox';
import { MatStepperModule } from '@angular/material/stepper';
import { MatDatepickerModule } from '@angular/material/datepicker';
import { MatNativeDateModule } from '@angular/material/core';
import { MatMenuModule } from '@angular/material/menu';
import { CooperateDetailsComponent } from './rg-cooperate/cooperate-details/cooperate-details.component';
import { AddCooperateMemberComponent } from './rg-cooperate/add-cooperate-member/add-cooperate-member.component';
import { EditCooperateMemberComponent } from './rg-cooperate/edit-cooperate-member/edit-cooperate-member.component';



@NgModule({
    declarations: [
        RgWastePickerComponent,
        RgCooperateComponent,
        RgHomeComponent,
        WastePickerDetailsComponent,
        EditWastePickerComponent,
        AddWastePickerComponent,
        ConsentDocsComponent,
        PersonalDetailsComponent,
        CollectionInfoComponent,
        SupportingDocsComponent,
        CooperateDetailsComponent,
        AddCooperateMemberComponent,
        EditCooperateMemberComponent,
    ],
    imports: [
        CommonModule,
        RegistrarRoutingModule,
        AgGridModule,
        ReactiveFormsModule,       
        ModalModule.forRoot(),
        SharedModule,
        MatInputModule,
        MatSelectModule,
        MatButtonModule,
        MatIconModule,
        MatCheckboxModule,
        MatStepperModule,
        MatDatepickerModule,
        MatNativeDateModule,
        MatMenuModule
    ]
})
export class RegistrarModule { }
