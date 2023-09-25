import { Component } from '@angular/core';

@Component({
  selector: 'app-calc',
  templateUrl: './calc.component.html',
  styleUrls: ['./calc.component.css']
})
export class CalcComponent {
   fValue : number = 0.0;
   sValue : number = 0.0;
   result : number = 0.0;
   operand : string = "";

   onProcess(){
    switch(this.operand){
      case "+" : this.result = this.fValue + this.sValue;break;
      case "-" : this.result = this.fValue - this.sValue;break;
      case "*" : this.result = this.fValue * this.sValue;break;
      case "/" : this.result = this.fValue / this.sValue;break;
    }
  }
}
