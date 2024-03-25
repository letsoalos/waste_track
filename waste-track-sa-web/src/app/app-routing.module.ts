import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { HomeComponent } from './home/home.component';

const routes: Routes = [
  
    { path: '', component: HomeComponent },
    { path: 'registrar', 
      loadChildren: () => import('./registrar/registrar.module').then(mod => mod.RegistrarModule),
      data: {breadcrumb: 'registrar'} 
    },    
    
    { path: 'verifier', loadChildren:()=> import('./verifier/verifier.module').then(x=>x.VerifierModule) },

    //{ path: 'card-issuer', component: WastePickerListComponent },  
    { path: '**', redirectTo: '', pathMatch: 'full'}
];

export default routes;


@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
