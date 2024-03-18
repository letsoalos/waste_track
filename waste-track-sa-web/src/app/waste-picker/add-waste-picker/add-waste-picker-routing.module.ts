import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule, Routes } from '@angular/router';
import { AddWastePickerComponent } from './add-waste-picker.component';

const routes: Routes = [
  { path: '', component: AddWastePickerComponent },
]

@NgModule({
  declarations: [],
  imports: [
    RouterModule.forChild(routes)
  ],
  exports: [
    RouterModule
  ]
})
export class AddWastePickerRoutingModule { }
