import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { WastePickerDetailsComponent } from './waste-picker-details/waste-picker-details.component';
import { WastePickerListComponent } from './waste-picker-list/waste-picker-list.component';
import { AddWastePickerComponent } from './add-waste-picker/add-waste-picker.component';


const routes: Routes = [
  { path: '', component: WastePickerListComponent },
  { path: ':id', component: WastePickerDetailsComponent },  
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
export class WastePickerRoutingModule { }
