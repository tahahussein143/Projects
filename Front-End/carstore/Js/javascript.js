function Clear(x) {
    document.getElementsByClassName("clear")[0].selectedIndex = 0;
    document.getElementsByClassName("clear")[1].selectedIndex = 0;

}

let regName = /^[a-z]+$/i
let regEmail = /^[a-z][a-z0-9_.]+@[a-z]+[.][a-z]+$/i
let regPhone = /^[0-9]{11}$/i
let regCard = /^[0-9]{16}$/i
let regadress = /^[a-z]+[-][a-z]+[-][a-z0-9]+$/i

function Valid() {
    if (regName.test(document.getElementById("name").value) == false) {
        document.getElementById("nameErr").innerHTML = "Please enter a valid name";
    }
    else document.getElementById("nameErr").innerHTML = "";

    if (regEmail.test(document.getElementById("email").value) == false) {
        document.getElementById("emailErr").innerHTML = "Please enter a valid email";
    }
    else document.getElementById("emailErr").innerHTML = "";

    if (regPhone.test(document.getElementById("phone").value) == false) {
        document.getElementById("phoneErr").innerHTML = "Please enter a valid phone";
    }
    else document.getElementById("phoneErr").innerHTML = "";

    if (regCard.test(document.getElementById("card").value) == false) {
        document.getElementById("cardErr").innerHTML = "Please enter a vaild credit card";
    }
    else document.getElementById("cardErr").innerHTML = "";

    if (regadress.test(document.getElementById("country").value) == false) {
        document.getElementById("countryErr").innerHTML = "Please enter a vaild address";
    }
    else document.getElementById("countryErr").innerHTML = "";



}



