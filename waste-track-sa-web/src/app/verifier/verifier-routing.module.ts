import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { VrHomeComponent } from './vr-home/vr-home.component';
import { VrMainComponent } from './vr-main/vr-main.component';
import { VrExtraComponent } from './vr-extra/vr-extra.component';

const routes: Routes = [
  { path: '', component: VrHomeComponent},
  //children: [
     { path: 'main', component: VrMainComponent},
     { path: 'extra', component: VrExtraComponent}     
   //]
  //}
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class VerifierRoutingModule { }
