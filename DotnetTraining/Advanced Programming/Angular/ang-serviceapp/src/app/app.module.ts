import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { AppRoutingModule } from './app-routing.module';
import { RouterModule } from '@angular/router';
import { HttpClientModule } from "@angular/common/http";

import { AppComponent } from './app.component';
import { NavBarComponent } from './Components/nav-bar/nav-bar.component';
import { EmpMgrComponentComponent } from './Components/emp-mgr-component/emp-mgr-component.component';
import { ViewEmpComponent } from './Components/view-emp/view-emp.component';
import { EditEmpComponent } from './Components/edit-emp/edit-emp.component';
import { AddEmpComponent } from './Components/add-emp/add-emp.component';
import { TemplateComponent } from './Components/template/template.component';
import { ReactiveFormsComponent } from './Components/reactive-forms/reactive-forms.component';
import { AdminRoutingModule } from './Modules/admin/admin-routing.module';


@NgModule({
  declarations: [
    AppComponent,
    NavBarComponent,
    EmpMgrComponentComponent,
    ViewEmpComponent,
    EditEmpComponent,
    AddEmpComponent,
    TemplateComponent,
    ReactiveFormsComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule,
    ReactiveFormsModule,
    HttpClientModule,
    AdminRoutingModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
