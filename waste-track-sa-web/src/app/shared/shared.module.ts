import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { CdkStepperModule } from '@angular/cdk/stepper';
import { ReactiveFormsModule } from '@angular/forms';
import { BsDropdownModule } from 'ngx-bootstrap/dropdown';
import { MatToolbarModule } from '@angular/material/toolbar';
import { MatIconModule } from '@angular/material/icon';
import { MatMenuModule } from '@angular/material/menu';
import { MatExpansionModule } from '@angular/material/expansion';
import { MatListModule } from '@angular/material/list';
import { MatSelectModule } from '@angular/material/select';
import { MatFormFieldModule } from '@angular/material/form-field';
import { MatSidenavModule } from '@angular/material/sidenav';
import { MatGridListModule } from '@angular/material/grid-list';
import { MatCardModule } from '@angular/material/card';

import { StepperComponent } from './components/stepper/stepper.component';
import { TextInputComponent } from './components/text-input/text-input.component'; // Import TextInputComponent here

@NgModule({
  declarations: [
    StepperComponent,
    TextInputComponent // Declare TextInputComponent here
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
    TextInputComponent, // Export TextInputComponent here
    CdkStepperModule,
    ReactiveFormsModule,
    MatToolbarModule,
    BsDropdownModule,
    MatIconModule,
    MatMenuModule,
    MatExpansionModule,
    MatListModule,
    MatSelectModule,
    MatFormFieldModule,
    MatSidenavModule,
    MatGridListModule,
    MatCardModule,
    TextInputComponent
  ]
})
export class SharedModule { }
