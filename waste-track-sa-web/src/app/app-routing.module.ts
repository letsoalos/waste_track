import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { HomeComponent } from './home/home.component';
import { WastePickerListComponent } from './waste-picker/waste-picker-list/waste-picker-list.component';
import { WastePickerDetailsComponent } from './waste-picker/waste-picker-details/waste-picker-details.component';

const routes: Routes = [
  
    { path: '', component: HomeComponent },
    { path: 'waste-picker', component: WastePickerListComponent },
    { path: 'waste-picker/:id', component: WastePickerDetailsComponent },  
    { path: '**', redirectTo: '', pathMatch: 'full'}
];

export default routes;


@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
