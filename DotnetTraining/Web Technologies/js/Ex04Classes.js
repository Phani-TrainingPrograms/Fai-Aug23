/** 
 * 3 ways to create classes in JS. 
 * Singleton objects that are created to be passed into a function at runtime.
 * Function based classes that was a feature on older JS Versions
 * class keyword introduced in ES6 version.  
*/

const empRec = {
    empName : "Phaniraj", 
    empAddress : "Bangalore",
    empSalary : 45000
}

const empRec2 = empRec;
empRec2.empSalary = 67000; //Changes made to the second object will be reflected on all the references of the object. 
console.log(empRec);
console.log(empRec.empName);

//Syntax of classes in older JS......
const Employee = function(id, name, address, salary, image){
    this.empId = id;
    this.empName = name;
    this.empAddress = address;
    this.empSalary = salary;
    this.pic = image;

    this.display = () =>{
        return `Name : ${this.empName} from ${this.empAddress}`
    }
}

const emp1 = new Employee(123, "Phaniraj", "Bangalore", 45000);
console.log(emp1.display());

const emp2 = new Employee(124, "Kumar", "Mysore", 55000);
console.log(emp2.display());

console.log(Employee);//Older syntax was actually a function that returned an object and the function called with new operator used to return a new object all the time


class EmpRepo{
 records = [
    new Employee(111, 'Phaniraj', 'Bangalore', 56000),
    new Employee(112, 'Ramesh', 'Bangalore', 36000),
    new Employee(113, 'Robert', 'Bangalore', 35000),
    new Employee(114, 'John', 'Bangalore', 30000)
 ];
 
 getAllEmployees = () => this.records;

 addEmployee = (emp) =>this.records.push(emp);

 updateEmployee = (id, emp) =>{
    const index = this.records.findIndex((e) => e.empId == id);
    this.records.splice(index, 1, emp);
 }

 deleteEmployee = (id) => {
    const index = this.records.findIndex((e) =>e.empId == id);
    if(index == -1)
       throw "Record not found!!!";
    this.records.splice(index, 1);
 }

 getEmpById = (id) => this.records.find((e) =>e.empId == id);

}
//testing:
// const repo = new EmpRepo();
// repo.addEmployee(new Employee(123, "Phaniraj", "Bangalore", 56000));
// const records = repo.getAllEmployees();
// records.forEach((rec) => console.log(rec.display()))