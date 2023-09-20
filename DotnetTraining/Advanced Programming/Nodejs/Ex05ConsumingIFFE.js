const cart = require("./Ex04IFFEModule").shoppingCart;

cart.addItem({id : 111, itemName : "Apples", price : 200});
cart.addItem({id : 112, itemName : "Mangoes", price : 400});
cart.addItem({id : 113, itemName : "Oranges", price : 100});
cart.addItem({id : 114, itemName : "Kiwis", price : 150});

const items = cart.getAll();
for (const item of items) {
    console.log(item);
}

const found = cart.find(113);
console.log(found);