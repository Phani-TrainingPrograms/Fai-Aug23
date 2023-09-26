const baseUrl = "http://localhost:5146/api/Example"
function onEdit(id) {
    const tempUrl = baseUrl + "/" + id;
    $.get(tempUrl, (data) => {
        $("#spID").text(data.id);
        getCategories();
        $("#slCategories").val(data.category);
    })
}

function getCategories() {
    const url = "http://localhost:5146/api/Example/Categories"
    $.get(url, (data) => {
        data.forEach((rec) => {
            const op = `<option>${rec}</option`
            $("#slCategories").append(op);
        })
    })
}
function onDisplay() {
    //hit the url and get the data. 
    $.get(baseUrl, (data) => {
        data.forEach(rec => {
            const div = `<div><h3>${rec.name}</h3><p>${rec.description}</p><p>${rec.category}</p><p><a href="${rec.fileLocation}">View Example</a></p><p><a class="btn btn-secondary" href="#" onclick="onEdit(${rec.id})">Edit</a></p></div>`
            $("#area").append(div);
        })
    });
}
function onAdd() {
    $("#spId").text("");
    $("#txtName").val("");
    $("#txtDesc").val("");
    $("#slCategories").val("");
    $("#txtFile").val("");
}

function onAddOp() {

}
function init() {
    $("a:first").click(onDisplay);
    $("a:eq(1)").click(onAdd);
    $("button:eq(1)").click(onAddOp);
}