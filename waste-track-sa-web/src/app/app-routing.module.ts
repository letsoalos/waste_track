import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { HomeComponent } from './home/home.component';
import { WastePickerListComponent } from './waste-picker/waste-picker-list/waste-picker-list.component';
import { WastePickerDetailsComponent } from './waste-picker/waste-picker-details/waste-picker-details.component';
import { AddWastePickerComponent } from './waste-picker/add-waste-picker/add-waste-picker.component';
import { ConsentDocsComponent } from './waste-picker/add-waste-picker/consent-docs/consent-docs.component';

const routes: Routes = [
  
    { path: '', component: HomeComponent },
    { path: 'waste-picker', component: WastePickerListComponent },
    { path: 'waste-picker/:id', component: WastePickerDetailsComponent },
    { path: 'consent', component: ConsentDocsComponent },
    { path: 'add-waste-picker', component: AddWastePickerComponent },  
    { path: '**', redirectTo: '', pathMatch: 'full'}
];

export default routes;


@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
