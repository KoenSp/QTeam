import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { FontAwesomeModule } from '@fortawesome/angular-fontawesome'; 
import { FormsModule } from '@angular/forms'; 
import { HttpClientModule } from '@angular/common/http';

import { AppComponent } from './app.component';
import { DataFormComponent } from './data-form/data-form.component';
import { PageNotFoundComponent } from './page-not-found/page-not-found.component';
import { QTeamService } from './services/q-team.service'; 

const appRoutes: Routes = [
  { path: 'data-form', component: DataFormComponent }, 
  { path: '', redirectTo: '/data-form', pathMatch: 'full' }, 
  { path: '**', component: PageNotFoundComponent }
]
@NgModule({
  declarations: [
    AppComponent,
    DataFormComponent,
    PageNotFoundComponent
  ],
  imports: [
    BrowserModule, 
    RouterModule.forRoot(
      appRoutes, 
      { enableTracing : true }
    ), 
    FontAwesomeModule, 
    FormsModule, 
    HttpClientModule
  ],
  providers: [
    QTeamService,
  ],
  bootstrap: [AppComponent]
})
export class AppModule { }
