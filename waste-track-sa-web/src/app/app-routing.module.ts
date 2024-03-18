import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { HomeComponent } from './home/home.component';
import { WastePickerListComponent } from './waste-picker/waste-picker-list/waste-picker-list.component';

const routes: Routes = [
  
    { path: '', component: HomeComponent },
    { path: 'waste-picker', 
      loadChildren: () => import('./waste-picker/waste-picker.module').then(mod => mod.WastePickerModule),
      data: {breadcrumb: 'Waste-Picker'} 
    },
    { path: 'add-waste-picker', 
    loadChildren: () => import('./waste-picker/add-waste-picker/add-waste-picker.module').then(mod => mod.AddWastePickerModule),
    data: {breadcrumb: 'Waste-Picker'} 
    },
    

 
    
    { path: 'verifier', loadChildren:()=> import('./verifier/verifier.module').then(x=>x.VerifierModule) },
    { path: 'card-issuer', component: WastePickerListComponent },  
    { path: '**', redirectTo: '', pathMatch: 'full'}
];

export default routes;


@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
