/**
 * Functions in Javascript can be created in 3 ways based on the version of ES.
 * Named Functions, Anonymous Functions and Lambda Functions.
 */
//Named Function
function addFunc(v1, v2){
    return v1 + v2;
}

const subFunc = function(v1, v2){
    return v1 - v2;
}

const mulFunc = (v1, v2) => v1 * v2;

const sumFunc = (...v) =>{//rest operator in JS ES8 feature...
    let val= 0.0;
    for(let item of v) {
        val += item;
    }
    return val;
}

console.log(`The Added value is ${addFunc(12,13)}`);
console.log(`The Added value is ${sumFunc(12,13,14,15,16,17)}`);
console.log(`The Subtracted value is ${subFunc(12,13)}`);
console.log(`The Multiplied value is ${mulFunc(12,13)}`);

