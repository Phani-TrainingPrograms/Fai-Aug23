const express = require("express");
const app = express();
const portNo = 1234;
const root = __dirname;
//A middleware is a logic that U want to inject to the pipeline of the request handling in Express. The Middleware always is a function that has 3 parameters:req, res and next where next is the reference to the next middleware of the pipeline if it exists.  practically middleware is used to authorize, authenticate, validation validation rules, process loggers and many more scenarios. U can add as many middlewares U want to the pipeline. 

function isAuthenticated(req, res, next){
    console.log("user is authenticated");
    next();
}

app.use(express.urlencoded({extended : false}));
app.use(isAuthenticated);

app.get("/", (req, res, next)=>{
    res.send("Hai from the server as Home Page");
    next();
})

app.post("/postRegister", (req, res)=>{
    const { txtName, txtEmail } = req.body;
    const msg = `<h1>Details of the Registered User</h1><hr/><p>The Name entered is ${txtName}</p><p>The Email Address is ${txtEmail}</p>`
    res.send(msg);
});

app.get("/employees", (req, res)=>{
    res.send("Employees Page");
});

app.get("/Register", (req, res)=>{
    res.sendFile(root + "/Registration.html")
})

app.get("/processRegister", (req, res)=>{
    const content = req.query;
    res.send(content);
})//todo:display the parts of the query 


app.listen(portNo, ()=>{
    console.log(`Server is running at port ${portNo}`);
});