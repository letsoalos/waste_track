import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { MuHomeComponent } from './mu-home/mu-home.component';

const routes: Routes = [
  { path: '', component: MuHomeComponent }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class MunicipalityRoutingModule { }
