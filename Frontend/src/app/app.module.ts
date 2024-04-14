import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';
import { HomeComponent } from './parts/home/home.component';
import { KolcsonzokComponent } from './parts/kolcsonzok/kolcsonzok.component';
import { KolcsonzesekComponent } from './parts/kolcsonzesek/kolcsonzesek.component';
import { FkfilterPipe } from './fkfilter.pipe';
import { FormsModule } from '@angular/forms';

@NgModule({
  declarations: [
    AppComponent,
    HomeComponent,
    KolcsonzokComponent,
    KolcsonzesekComponent,
    FkfilterPipe
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    NgbModule,
    FormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
