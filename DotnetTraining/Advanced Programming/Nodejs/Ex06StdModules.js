//Nodejs gives a set of predefined modules that can be used like Apis in your nodejs apps. Some of the modules are FileIO(fs), OperatingSystem(os), web server(http) and many more.

const fs = require('fs');
//This is the sync version: The next line of the statement would not execute till the readFileSync returns...
//const content = fs.readFileSync("Ex06StdModules.js", 'utf-8');
//console.log(content);
//////////////////Reading file asynchronously///////////////
fs.readFile("Ex04IFFEModule.js",'utf-8', (err, data)=>{
    if(err){
        console.log(err);
    }else{
        console.log(data);
    }
})
console.log("End of the file");

const file = "testFile.txt";
fs.writeFileSync(file, "contents of this file to write", 'utf-8');
//todo:try the async version of the writeFile also...

