import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { DashboardComponent } from 'src/app/Components/dashboard/dashboard.component';
import { RightsComponent } from 'src/app/Components/rights/rights.component';
import { UserComponent } from 'src/app/Components/user/user.component';
import { RouterModule, Routes } from '@angular/router';
import { AdminRoutingModule } from './admin-routing.module';


@NgModule({
  declarations: [
    DashboardComponent,
    RightsComponent,
    UserComponent
  ],
  imports: [
    AdminRoutingModule
  ]
})
export class AdminModule { }
