import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { VerifierRoutingModule } from './verifier-routing.module';
import { VrHomeComponent } from './vr-home/vr-home.component';
import { VrMainComponent } from './vr-main/vr-main.component';
import { VrExtraComponent } from './vr-extra/vr-extra.component';


@NgModule({
  declarations: [
    VrHomeComponent,
    VrMainComponent,
    VrExtraComponent
  ],
  imports: [
    CommonModule,
    VerifierRoutingModule
  ]
})
export class VerifierModule { }
