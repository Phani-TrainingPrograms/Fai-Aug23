const express = require("express");
const app = express();
app.use(express.json());
app.use(express.urlencoded({ extended : true}));

app.get("/", (req, res)=>{
    res.sendFile(__dirname + "/ClientApp.html");
})

app.listen(4321, ()=>{
    console.log("Client App is running at 4321");
});