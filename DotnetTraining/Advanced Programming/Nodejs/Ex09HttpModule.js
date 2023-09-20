//http module is used for creating Http services for Ur application. this includes html page rendering, api rendering and many more server side API development. 
//http allows to create web servers in ur environment with little infrastructure, very helpful for IoT kind of Apps where there is no scope of heavy infrastructure. 

const http = require("http");
const portNo = 1234;

const processRequest = (req, res)=>{
    console.log(req.url);
    switch (req.url) {
        case '/favicon.ico':
            break;
        case '/Employees':
            res.end("<h1>Employees page</h1>");
            break;
        case '/Customers':
            res.end("<h1>Customers page</h1>");
            break;
        case '/Patients':
            res.end("<h1>Patients page</h1>");
            break;
        case '/':
            res.end("<h1>Home page</h1>");
            break;
        default:
            res.end("<h1>No Page found</h1>")
            break;
    }
}
http.createServer((req, res)=>{
    processRequest(req, res);
}).listen(portNo);
