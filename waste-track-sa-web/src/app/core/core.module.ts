import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { NavBarComponent } from './nav-bar/nav-bar.component';
import { FooterComponent } from './footer/footer.component';
import { RouterModule } from '@angular/router';
import { SharedModule } from '../shared/shared.module';
import { SidebarComponent } from './sidebar/sidebar.component';
import { MainWindowComponent } from './main-window/main-window.component';



@NgModule({
  declarations: [
    NavBarComponent,
    FooterComponent,
    SidebarComponent,
    MainWindowComponent
  ],
  imports: [
    CommonModule,
    RouterModule,
    SharedModule
  ],
  exports: [
    NavBarComponent,
    FooterComponent,
    SidebarComponent,
    MainWindowComponent
  ]
})
export class CoreModule { }
