import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { FormsModule } from '@angular/forms';
import { AppRoutingModule } from './app-routing.module';

import { AppComponent } from './app.component';
import { NavBarComponent } from './Components/nav-bar/nav-bar.component';
import { EmpMgrComponentComponent } from './Components/emp-mgr-component/emp-mgr-component.component';
import { ViewEmpComponent } from './Components/view-emp/view-emp.component';
import { EditEmpComponent } from './Components/edit-emp/edit-emp.component';
import { AddEmpComponent } from './Components/add-emp/add-emp.component';

@NgModule({
  declarations: [
    AppComponent,
    NavBarComponent,
    EmpMgrComponentComponent,
    ViewEmpComponent,
    EditEmpComponent,
    AddEmpComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    FormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
