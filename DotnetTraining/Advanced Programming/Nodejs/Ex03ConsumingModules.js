const allObjects = require("./Ex02Modules");
const emp = require("./Ex02Modules").empObj;
const tFunc = require("./Ex02Modules").testFunc;

//emp is the alias of the module export called empObj
console.log(emp);

tFunc();

allObjects.testFunc();
console.log(allObjects.empObj);
allObjects.multiplicationTable();

const cst1 = new allObjects.customer(123, "Phaniraj", 3453454, 560);
console.log(cst1);