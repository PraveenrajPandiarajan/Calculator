function addTextToInput(i) {
    var text = document.getElementById("tot").value;
    document.getElementById("tot").value = text + i;
}
function clr() {
    document.getElementById("tot").value = ""
}
function equal() {
    let x = document.getElementById("tot").value
    let y = eval(x)
    document.getElementById("tot").value = y
    
}

