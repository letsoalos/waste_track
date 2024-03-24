import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { StepperComponent } from './components/stepper/stepper.component';
import {CdkStepperModule} from '@angular/cdk/stepper';
import { ReactiveFormsModule } from '@angular/forms';
import { BsDropdownModule } from 'ngx-bootstrap/dropdown';
import { MatToolbarModule } from '@angular/material/toolbar';
import { MatIconModule } from '@angular/material/icon';



@NgModule({
  declarations: [
    StepperComponent
  ],
  imports: [
    CommonModule,
    CdkStepperModule,
    ReactiveFormsModule,
    MatToolbarModule,
    MatIconModule,
    BsDropdownModule.forRoot()
  ],
  exports: [
    StepperComponent,
    CdkStepperModule,
    ReactiveFormsModule,
    MatToolbarModule,
    BsDropdownModule,
    MatIconModule
  ]
})
export class SharedModule { }
