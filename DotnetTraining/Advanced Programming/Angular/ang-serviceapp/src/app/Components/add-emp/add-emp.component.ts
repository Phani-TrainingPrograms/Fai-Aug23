import { Component } from '@angular/core';
import { Router } from '@angular/router';
import { Employee } from 'src/app/Models/employee';
import { EmployeeService } from 'src/app/Services/employee.service';

@Component({
  selector: 'app-add-emp',
  templateUrl: './add-emp.component.html',
  styleUrls: ['./add-emp.component.css']
})
export class AddEmpComponent {
   newEmp : Employee = {} as Employee;
   
   constructor(private myService : EmployeeService, private router : Router) {
    
   }

   onNewEmp(){
    debugger;
    const file = this.newEmp.imageFile;
    this.newEmp.imageFile = "assets/images/" + file;
    this.myService.addEmployee(this.newEmp).subscribe((emp)=>{
      alert("Employee added successfully");
      this.router.navigate(['/']);
    });
   }

}
