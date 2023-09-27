import { Component } from '@angular/core';

@Component({
  selector: 'app-dashboard',
  template: '<h1>{{title}}</h1>'
})
export class DashboardComponent {
  title : string = "App Admin Dashboard"
}
