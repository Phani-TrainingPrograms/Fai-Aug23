import { Component } from '@angular/core';

@Component({
  selector: 'app-user',
  template: '<h1>{{title}}</h1>'
})
export class UserComponent {
  title : string = "User Component"
}
