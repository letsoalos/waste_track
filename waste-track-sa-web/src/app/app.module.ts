import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { HttpClientModule } from '@angular/common/http';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { CoreModule } from './core/core.module';
import { WastePickerModule } from './waste-picker/waste-picker.module';
import { HomeModule } from './home/home.module';
import { NgxExtendedPdfViewerModule } from 'ngx-extended-pdf-viewer';

@NgModule({
  declarations: [
    AppComponent,
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    BrowserAnimationsModule,
    HttpClientModule,
    CoreModule,
    WastePickerModule,
    HomeModule,
    WastePickerModule,
    NgxExtendedPdfViewerModule    
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
