import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { FormsModule } from "@angular/forms";
import { AppComponent } from './app.component';
import { CalcComponent } from './Components/calc/calc.component';
import { EmpDetailComponent } from './Components/emp-detail/emp-detail.component';
import { MasterComponent } from './Components/master/master.component';

@NgModule({
  declarations: [
    AppComponent,
    CalcComponent,
    EmpDetailComponent,
    MasterComponent
  ],
  imports: [
    BrowserModule,
    FormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
