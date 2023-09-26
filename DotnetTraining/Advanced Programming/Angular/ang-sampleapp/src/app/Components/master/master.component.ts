import { Component, OnInit } from '@angular/core';
import { Employee } from 'src/app/Models/employee';

@Component({
  selector: 'app-master',
  templateUrl: './master.component.html',
  styleUrls: ['./master.component.css']
})
export class MasterComponent implements OnInit {
  ngOnInit(): void {
    this.empList.push({
      empId : 123, empName : "Phaniraj", empAddress : "Bangalore", empSalary : 56000, picture : 'assets/images/pic1.png'
    });
    this.empList.push({
      empId : 124, empName : "Banu Prakash", empAddress : "Mysore", empSalary : 16000, picture : 'assets/images/pic6.png'
    });
    this.empList.push({
      empId : 125, empName : "Vinod Kumar", empAddress : "Shimogga", empSalary : 56000, picture : 'assets/images/pic5.png'
    });
    this.empList.push({
      empId : 126, empName : "Joydip Mondal", empAddress : "Kolkatta", empSalary : 56000, picture : 'assets/images/pic4.png'
    });
    this.empList.push({
      empId : 127, empName : "Ramnath Nishad", empAddress : "Patna", empSalary : 56000, picture : 'assets/images/pic3.png'
    });
    this.empList.push({
      empId : 128, empName : "Phaniraj", empAddress : "Bangalore", empSalary : 56000, picture : 'assets/images/pic2.png'
    });
  }
  empList : Employee[] = [];

  onDataModified(modified : Employee){
    //code to update the Array..
    const index = this.empList.findIndex(e => e.empId == modified.empId);
    if(index < 0){
      alert("No employee is found");
    }else{
      this.empList.splice(index, 1, modified);
      alert("Employee is updated to the database")
    } 
  }

  onDataDeleted(no : number){
    const index = this.empList.findIndex(e => e.empId == no);
    if(index < 0){
      alert("Employee not found to delete");
    }else{
      this.empList.splice(index, 1);
      alert("Employee is deleted")
    }
  }
}
