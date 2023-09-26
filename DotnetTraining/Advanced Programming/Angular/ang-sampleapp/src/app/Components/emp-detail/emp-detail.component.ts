import { Component, EventEmitter, Input, OnInit, Output } from '@angular/core';
import { Employee } from 'src/app/Models/employee';

@Component({
  selector: 'app-emp-detail',
  templateUrl: './emp-detail.component.html'
})
export class EmpDetailComponent implements OnInit{
  @Output() onUpdate : EventEmitter<Employee> = new EventEmitter<Employee>();
  @Output() onDelete : EventEmitter<number> = new EventEmitter<number>();
  @Input() empObj = {} as Employee
  ngOnInit(): void {
  }
  //event handler for the edit button 
  onEmployeeUpdate(){
    alert(JSON.stringify(this.empObj));
    this.onUpdate.emit(this.empObj);
  }

  //event handler for the delete button
  onEmployeeDelete(){
    this.onDelete.emit(this.empObj.empId);    
  }
}
