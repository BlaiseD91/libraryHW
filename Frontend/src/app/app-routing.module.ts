import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { HomeComponent } from './parts/home/home.component';
import { KolcsonzokComponent } from './parts/kolcsonzok/kolcsonzok.component';
import { HttpClientModule } from '@angular/common/http';

const routes: Routes = [
  {path: "", redirectTo: "/home", pathMatch: "full"},
  {path: "home", component:HomeComponent},
  {path: "kolcsonzok", component:KolcsonzokComponent},
  {path: "**", component:HomeComponent},
];

@NgModule({
  imports: [
    RouterModule.forRoot(routes),
    HttpClientModule
  ],
  exports: [RouterModule]
})
export class AppRoutingModule { }
