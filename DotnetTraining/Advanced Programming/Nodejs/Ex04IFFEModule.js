//IFFE stands for Immediately Invoked Functional Expression which returns an object directly from the module without a need to create an object. Helpfull for singleton objects. 

module.exports.shoppingCart = (function(){
    let cart = [];

    addItem = (item) => cart.push(item);

    getAll = () => cart;

    find = (id) => cart.find(i => i.id == id);

    return{
        addItem, getAll,  find
    }
})();
