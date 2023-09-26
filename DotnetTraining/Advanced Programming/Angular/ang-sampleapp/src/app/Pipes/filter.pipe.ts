import { Pipe, PipeTransform } from '@angular/core';
import { Employee } from '../Models/employee';

@Pipe({
  name: 'filter'
})
export class FilterPipe implements PipeTransform {
  //the base data, args if any and returns the transformed data
  transform(inputs : Employee[], arg : string): Employee[] {
    if(arg == ""){
      return inputs;
    }else{
      return inputs.filter(e => e.empName.includes(arg))
    }
  }
}
