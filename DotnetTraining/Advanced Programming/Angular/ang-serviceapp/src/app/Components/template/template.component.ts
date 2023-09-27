import { Component, OnInit } from '@angular/core';
import { Employee } from 'src/app/Models/employee';

@Component({
  selector: 'app-template',
  templateUrl: './template.component.html',
  styleUrls: ['./template.component.css']
})

export class TemplateComponent implements OnInit {
  // The data that needs to be validated. 
  emp : Employee = {} as Employee;

  ngOnInit(): void {
    this.emp = {
      empId : 0, empName : "", emailAddress : "", phoneNo : 0, imageFile : ""
    } as Employee;
  }
  //Event handler for the Submit button of the Component.
  onSubmit(empForm : any){
    alert("Employee object is validated");
    console.log(empForm.value);
  }
}
