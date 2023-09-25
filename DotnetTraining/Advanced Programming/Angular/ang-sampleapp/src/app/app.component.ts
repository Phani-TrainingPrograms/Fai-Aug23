import { Component } from '@angular/core';
import { Employee } from './Models/employee';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title : string = "Welcome to Angular training!!!"
  userDetails : Employee = {
    empId : 123, empName : "Phaniraj", empAddress : "Bangalore", empSalary : 45000, picture : ""
  }

  onClick = () => alert("Button was clicked")
}
