import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { StepperComponent } from './components/stepper/stepper.component';
import {CdkStepperModule} from '@angular/cdk/stepper';
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
import { MatGridListModule } from '@angular/material/grid-list'; // Import MatGridListModule
import { MatCardModule } from '@angular/material/card'



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
    MatIconModule,
    MatMenuModule,
    MatExpansionModule,
    MatListModule,
    MatSelectModule,
    MatFormFieldModule,
    MatSidenavModule,
    MatGridListModule, // Add MatGridListModule to imports array
    MatCardModule
    
    
        

  ]
})
export class SharedModule { }
