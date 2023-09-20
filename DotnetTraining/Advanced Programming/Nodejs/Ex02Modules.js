//Functions or classes that needs to be consumed by other JS files are created using module.exports function.
//module.exports is the older version of nodejs, however, major apps use the ES6 version of exports syntax.

module.exports.testFunc = () => console.log("Test Func from a module");

module.exports.empObj = {
    empName : "Phaniraj", 
    empAddress : "Bangalore",
    empSalary : "45000"
}

module.exports.multiplicationTable = (no)=>{
    if(isNaN(no)){
        console.log("Not possible");
        return
    }
    console.log("Multiplication table for " + no);
    for (let i = 1; i < 11; i++) {
        console.log(`${no} X ${i} = ${no * i}`)
    }
    console.log("End of the table");
}

//todo: create a multiplication table for given no from 1 to 10...

module.exports.customer = class{
    constructor(id, name, phone, bill){
        this.id = id;
        this.name = name;
        this.phone = phone;
        this.bill = bill;
    }
}