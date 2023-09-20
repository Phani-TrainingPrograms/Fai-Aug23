const http = require("http");
const fs = require("fs");
const qs = require('querystring');
const parse = require('url').parse;//For Http GET Processing...
const curDir = __dirname;//__dirname is the const name for the current directory of the nodejs app

//helper function for handling html pages...
function renderHtml(fileName, res){
    const file = curDir + fileName;
    fs.createReadStream(file).pipe(res);
}

function processGet(req, res, inputs){
    const msg = `<h1>Registration Processing Page</h1><hr/><p>Welcome to Mr. ${inputs.txtName}</p><p>UR Registered Email Address is ${inputs.txtEmail}</p><p>We will keep you posted on other details shortly</p>`
    res.end(msg);
}

function processPost(req, res){
    let inputs = "";
    req.on("data", (result)=>{
        inputs += result;
    })

    req.on("end", ()=>{
        const data = qs.parse(inputs);
        const msg = `<h1>Registration Processing Page</h1><hr/><p>Welcome to Mr. ${data.txtName}</p><p>UR Registered Email Address is ${data.txtEmail}</p><p>We will keep you posted on other details shortly</p>`
        res.end(msg);
    })
}

function processRequest(req, res){
    if(req.url == '/favicon.ico') return;
    else{
        if(req.method == 'POST'){
            processPost(req, res);
            return;
        }
        const inputs = parse(req.url, true).query;
        if(inputs.txtName != undefined){
            processGet(req, res, inputs);
        }else{
            switch(req.url){
                case "/" : res.end("<h1>Home Page</h1>"); break;
                case '/Register' : renderHtml("/Registration.html", res); return;
                case "/getInfo" : res.end("Page is processed");break;
                case "/records" : renderHtml("/data.json", res); return;
                case "/display" : renderHtml("/Display.html", res); return;
                default: renderHtml("/ErrorPage.html", res); return;
            }
        }
    }
}

http.createServer((req, res)=>{
    processRequest(req, res)
}).listen(1234);