const os = require('os');
////////////////////////////////Using os module////////
//os module is used to get info about the Os on which the Nodejs is running. It includes info about the type of Os, its name, machine name, cores, memory, threads, processes and many other OS level info.

console.log(os.userInfo());
console.log("The computer name: " + os.hostname());
console.log("The Computer platform is " + os.platform());
console.log("The architecture of Os is " + os.arch());
console.log("The total no of CPUs in my machine is " + os.cpus().length);
console.log("The Computer is running for " + os.uptime() /3600 + " hrs");
const cpus = os.cpus();
for(let cpu of cpus){
    console.log(cpu);
}
console.log("The amount of free memory is " + os.freemem());//convert it into MB....
console.log("The total memory is " + os.totalmem());
