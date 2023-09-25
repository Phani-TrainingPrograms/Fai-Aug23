import { Component, Input, OnInit } from '@angular/core';
import { Employee } from 'src/app/Models/employee';

@Component({
  selector: 'app-emp-detail',
  templateUrl: './emp-detail.component.html'
})
export class EmpDetailComponent implements OnInit{
  @Input() empObj = {} as Employee
  ngOnInit(): void {
  }
}
