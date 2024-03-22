import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { RgHomeComponent } from './rg-home/rg-home.component';
import { RgWastePickerComponent } from './rg-waste-picker/rg-waste-picker.component';
import { RgCooperateComponent } from './rg-cooperate/rg-cooperate.component';
import { WastePickerDetailsComponent } from './rg-waste-picker/waste-picker-details/waste-picker-details.component';
import { AddWastePickerComponent } from './rg-waste-picker/add-waste-picker/add-waste-picker.component';

const routes: Routes = [
  { path: '', component: RgHomeComponent },
  { path: 'waste-picker/add-waste-picker', component: AddWastePickerComponent }, // Move this route up
  { path: 'waste-picker', component: RgWastePickerComponent },
  { path: 'cooperate', component: RgCooperateComponent },
  { path: 'waste-picker/:id', component: WastePickerDetailsComponent },
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class RegistrarRoutingModule { 
  constructor() {
    console.log('RegistrarRoutingModule loaded.');
  }
}


