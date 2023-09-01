/*
JS code runs either on browser or on a NODEJS Environment. Nodejs is a platform for running JS Applications from a terminal. NODEJS came from 2012 onwards. In our Examples, we will run on the HTML Pages which are executed on the browsers. All modren Browsers have JS interpretors in them and can be used to execute the JS code. 
JS uses the stds defined by ECMA(European Computer Manufacturers Association). It is called ECMA Script or simply ES. Every Year, ES releases new stds and new features to JS. 
Major change happened in ES6 and ES7 version.
JS is easy to learn, simple syntax and powerful features.  
*/

/*********************************UI Based Functions:****************************
alert("Testing 123") //====> Displays the message box on the Browser. 

const empname = prompt("Enter UR Name")//Const is a way of declaring consts in JS: ES6
alert(empname)

const answer = confirm("Do U really want to learn JS");
if(answer){
    alert("U R a good programmer")
}else{
    alert("U R not learning a powerfull language")
}
/**************************variable declarations*************************************
//let, var and const are the ways of creating variables in JS. var is the older way and is not recommended for newer JS Apps. let is more scope based than var and is very powerful in terms of declaration and usage.  
//try changing to var and see the difference in the console of the browser. 
let example = 123;
{
    let example = 345;
    console.log(example);//354
}
console.log(example)//123
**************************Data types of JS*************************************
//undefined is a state in JS where a variable is not initialized or does not exist in the scope and the program is trying to access it. 
let value = 123;
console.log(typeof(value))
value = "Sample Text";
console.log(typeof(value))
value = true;
console.log(typeof(value))
value = { name : 'Phaniraj', address : 'Bangalore'};
console.log(typeof(value))
let x;
console.log(typeof(x));
let testing = { data : 123}
console.log(testing. data123);

////Diiferent kinds of data in JS: number(both floating and integral), bool(true and false), object(Arrays, objects)
***********************Arrays in JS**********************/
const elements = [123,23,45,56,6];
console.log(elements);
console.log("using for loop");
for(let i =0; i < elements.length; i++) 
    console.log(elements[i]);

console.log("using for...of loop")
for(const element of elements)
    console.log(element);

console.log("using foreach in JS")
elements.forEach((element)=>{
    console.log(element)
})

elements.push(56);//adds the element to the bottom of the array. 
console.log(`The no of elements in the array is ${elements.length}`)
//Arrays are dynamic in JS...

elements.unshift(543);//adds the element to the begining of the array.
console.log(elements)

elements.splice(3, 1);//Is used to remove, update or add item to the array. In this example it is removing 1 item from the index 3 of the array. 
console.log(elements)

//todo: create an example of using splice method that does all the 3 operations; delete, insert or update. 

const index = elements.indexOf(56);
if(index == -1)
    console.log("Element does not exist in the array");
else
    console.log(`The index of 56 is ${index}`)

//todo: Find what Find, Filter, FindIndex functions do.....

