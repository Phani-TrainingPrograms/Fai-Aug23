//Events are actions performed by the object. The handler for the action(event) is called as Event handler. The Event handler will be invoked implicitly when the event occurs. 
//As a programmer, U should define the moment on the event occuring and as a consumer U should define the handler for the event when it occurs. There is an event emitter module that allows to trigger and handle the events. 
const events = require('events');
const ev = new events();

const btn = new events();
btn.on("click", ()=>{
    console.log("Button was clicked");
})
//registering the event and telling what to do when the event occurs. Here the string is the event name,
ev.on("test", ()=>{
    console.log("test event is triggered");
})

ev.on("run", ()=>{
    console.log("run event is triggered");
})

ev.emit("run");
ev.emit("test");//emit is the function used to raise the event...

btn.emit("click");