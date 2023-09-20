//Data Source=.\SQLEXPRESS;Initial Catalog=FaiTraining;Integrated Security=True
//npm i --save msnodesqlv8
const express = require("express");
const sql = require('msnodesqlv8');
const cors = require('cors');
const app = express();

///////////////Middlewares for the App//////////////////////////
app.use(express.json());//to parse json data sent thru body...
app.use(express.urlencoded({extended : true}));//body will be processed as JSON data...
app.use(cors())//To enable CORS for outside apps...

function validationRules(req, res, next){
    const { empName, empAddress } = req.body;
    if(empAddress == ""){
        return res.send("address is mandatory")
    };
    if(empName == ""){
        return res.send("name is must");
    }
    next();
}

//////////Database config/////////////////////////////////////
const server = '.\\SQLEXPRESS';
const dbName = 'FaiTraining';
const driver = 'SQL Server Native Client 11.0';
const conString = `Server={${server}}; Database={${dbName}}; Trusted_Connection=Yes;Driver={${driver}};`;


///////////////////////////////////////////////
//const conString = `Server={${server}}; Database={${dbName}}; Trusted_Connection=Yes;Driver={${driver}}; UId={${userid}}; Pwd={${pwd}}`;



const query = "SELECT * FROM Emptable";

/**
 * GET http://localhost:1234/Employees
 */
app.get("/Employees", (req, res)=>{
    sql.query(conString, query, (err, rows)=>{
        if (err) {
            res.send(err);
        } else {
            res.send(rows);
        }
    })
});

/**
 * GET: http://localhost:1234/Employees/id
 * get the Employee by id..
 */
app.get("/Employees/:id", (req, res)=>{
    const id = req.params.id;
    const query = `select * from Emptable where empId = ${id}`;
    sql.query(conString, query, (err, rows)=>{
        res.send(rows[0])
    });
});

/**
 * POST http://localhost:1234/Employees
 * Adds a new Employee to the system
 */
app.post("/Employees", validationRules, (req, res)=>{
    const body = req.body;
    const query = `Insert into EmpTable values('${body.empName}','${body.empAddress}',${body.empSalary}, ${body.DeptId})`;
    sql.query(conString, query, (err, rows)=>{
        if (err) {
            res.send(err.message);
        } else {
            res.send("Employee added successfully");
        }
    })
})


app.put("/Employees/:id", validationRules, (req, res)=>{
    const id = req.params.id;
    console.log(id)
    const body = req.body;
    console.log(body)
    const query = `Update EmpTable Set empName = '${body.empName}',empAddress = '${body.empAddress}',empSalary = ${body.empSalary}, DeptId = '${body.DeptId}' where empId = ${id}`

    sql.query(conString, query, (err, rows)=>{
        if(err){
            res.status(400).send(err.message);
        }else{
            res.status(200).send("employee updated successfully");
        }
    })
});

app.delete("/Employees/:id", (req, res)=>{
    const id = req.params.id;
    const query = "Delete from EmpTable Where Empid = " + id;
    sql.query(conString, query, (err, rows) => {
        if (err) {
            res.status(400).send(err.message);
        } else {
            res.status(200).send("employee deleted successfully");
        }
    })
})
app.listen(1234, ()=>{
    console.log("Server at 1234");
});
//todo: Create the Nodejs app that stores data in the CSV file using HTTP POST. The App should show a HTML page where user makes entries and when the user posts the data, it should append to a CSV file. The Get operation should display the Data in the HTML document in the form of table. 
 