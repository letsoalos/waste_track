import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { WastePickerDetailsComponent } from './waste-picker-details/waste-picker-details.component';
import { WastePickerListComponent } from './waste-picker-list/waste-picker-list.component';


const routes: Routes = [
  { path: '', component: WastePickerListComponent },
  { path: ':id', component: WastePickerDetailsComponent },  
  //{ path: 'waste-picker-list', component: WastePickerListComponent },
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
