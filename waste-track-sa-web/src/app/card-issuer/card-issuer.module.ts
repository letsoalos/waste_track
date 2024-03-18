import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { CardIssuerRoutingModule } from './card-issuer-routing.module';
import { VrExtraComponent } from './vr-extra/vr-extra.component';
import { VrMainComponent } from './vr-main/vr-main.component';
import { VrHomeComponent } from './vr-home/vr-home.component';


@NgModule({
  declarations: [
    VrExtraComponent,
    VrMainComponent,
    VrHomeComponent
  ],
  imports: [
    CommonModule,
    CardIssuerRoutingModule
  ]
})
export class CardIssuerModule { }
