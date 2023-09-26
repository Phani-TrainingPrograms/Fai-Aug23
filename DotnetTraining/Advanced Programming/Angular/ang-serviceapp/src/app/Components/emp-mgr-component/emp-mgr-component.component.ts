import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { Employee } from 'src/app/Models/employee';
import { EmployeeService } from 'src/app/Services/employee.service';

@Component({
  selector: 'app-emp-mgr-component',
  templateUrl: './emp-mgr-component.component.html',
  styleUrls: ['./emp-mgr-component.component.css']
})
export class EmpMgrComponentComponent implements OnInit {
  empList : Employee[] = [];
  constructor(private myService : EmployeeService, private router : Router) {

  }
  ngOnInit(): void {
    this.myService.getAllEmployees().subscribe((data : Employee[])=>{
      this.empList = data
    })
  }

  onDelete(id : number){
    this.myService.deleteEmployee(id).subscribe(data=>{
      alert(data);
      this.router.navigate(["/"]);
    })
  }
}
