function veriAl() {
    var yanit = "";
    var istek = new XMLHttpRequest();
    istek.onload = function () {
        yanit = this.responseText;
    }
    istek.open("GET", "http://localhost:29105/api/Area");
    istek.send();
    return yanit;
}

function veriYaz() {
    document.getElementById("veri").innerHTML = veriAl();
}