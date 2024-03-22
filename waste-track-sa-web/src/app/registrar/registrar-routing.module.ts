import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { RgHomeComponent } from './rg-home/rg-home.component';
import { RgWastePickerComponent } from './rg-waste-picker/rg-waste-picker.component';
import { RgCooperateComponent } from './rg-cooperate/rg-cooperate.component';

const routes: Routes = [
  { path: '', component: RgHomeComponent,
  //children: [
     //{ path: 'waste-picker', component: RgWastePickerComponent},
     //{ path: 'cooperate', component: RgCooperateComponent}     
   //]
  },
  { path: 'waste-picker', component: RgWastePickerComponent},
  { path: 'cooperate', component: RgCooperateComponent} 
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


