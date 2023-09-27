import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { Employee } from '../Models/employee';

//use Constructors to inject the dependencies for the component or the class and use OnInit Interface for initializing the data of the Components. 

@Injectable({
  providedIn: 'root'
})
export class EmployeeService {
  baseUrl : string = "http://localhost:5146/api/Employee";

  constructor(private http : HttpClient) { }

  public getAllEmployees() : Observable<Employee[]>{
    return this.http.get<Employee[]>(this.baseUrl);
  }

  public getEmployee(id : number) : Observable<Employee>{
    let tempUrl = this.baseUrl + "/" + id;
    return this.http.get<Employee>(tempUrl);
  }

  public addEmployee(emp: Employee) : Observable<Employee>{
    return this.http.post<Employee>(this.baseUrl, emp);
  }

  public deleteEmployee(id : number) : Observable<string>{
    let tempUrl = this.baseUrl + "/" + id;
    return this.http.delete<string>(tempUrl);
  }

  public updateEmployee(emp : Employee) : Observable<Employee>{
    let tempUrl = this.baseUrl + "/" + emp.empId;
    return this.http.put<Employee>(tempUrl, emp); 
  }
}
