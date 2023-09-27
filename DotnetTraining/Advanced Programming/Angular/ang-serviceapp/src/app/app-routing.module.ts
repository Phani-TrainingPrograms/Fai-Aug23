import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { EmpMgrComponentComponent } from './Components/emp-mgr-component/emp-mgr-component.component';
import { AddEmpComponent } from './Components/add-emp/add-emp.component';
import { ViewEmpComponent } from './Components/view-emp/view-emp.component';
import { EditEmpComponent } from './Components/edit-emp/edit-emp.component';
import { TemplateComponent } from './Components/template/template.component';
import { ReactiveFormsComponent } from './Components/reactive-forms/reactive-forms.component';

const routes: Routes = [
  {path: '', redirectTo: "employees", pathMatch:'full'},
  {path : 'employees', component: EmpMgrComponentComponent},
  {path : 'employees/add', component:AddEmpComponent},
  {path : 'employees/view/:id', component : ViewEmpComponent},
  {path : 'employees/edit/:id', component : EditEmpComponent},
  {path : 'validation/template', component : TemplateComponent},
  {path : 'validation/reactive', component : ReactiveFormsComponent},
  {path : 'admin', loadChildren: () => import("./Modules/admin/admin.module").then(m=>m.AdminModule)}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
