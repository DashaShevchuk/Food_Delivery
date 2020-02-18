function CheckLogin() {
    let login = document.getElementById("reg-login").value;

    if (login == "") {
        document.getElementById("reg-errorlogin").innerHTML = "*Логін пустий";
        document.getElementById("reg-login").style.border = "solid red 1px";
        document.getElementById("reg-errorlogin").style.color = "red";
    }
    else {
        document.getElementById("reg-errorlogin").innerHTML = " ";
    }
}

function CheckEmail() {
    let email = document.getElementById("reg-email").value;
    const emailRegex = /@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$/;

    if (email == "") {
        document.getElementById("reg-erroremail").innerHTML = "*Email пустий";
        document.getElementById("reg-email").style.border = "solid red 1px";
        document.getElementById("reg-errorlogin").style.color = "red";
    }
    else if (!emailRegex.test(email)) {
        document.getElementById("reg-email").style.border = "solid red 1px";
        document.getElementById("reg-erroremail").style.color = "red";
        document.getElementById("reg-erroremail").innerHTML = "*Email не коректний";
    }
    else {
        document.getElementById("reg-erroremail").innerHTML = " ";
    }
}

function CheckFirstName() {
    let email = document.getElementById("reg-firstname").value;

    if (email == "") {
        document.getElementById("reg-firstname").innerHTML = "*Введіть ім'я";
        document.getElementById("reg-firstname").style.border = "solid red 1px";
        document.getElementById("reg-errorfirstname").style.color = "red";
    }

    else {
        document.getElementById("reg-errorfirstname").innerHTML = " ";
    }
}

function CheckLastName() {
    let email = document.getElementById("reg-lastname").value;

    if (email == "") {
        document.getElementById("reg-lastname").innerHTML = "*Введіть ім'я";
        document.getElementById("reg-lastname").style.border = "solid red 1px";
        document.getElementById("reg-errorlastname").style.color = "red";
    }

    else {
        document.getElementById("reg-errorlastname").innerHTML = " ";
    }
}
function CheckPassword() {
    let password = document.getElementById("password").value;
    const passwordRegex = /^(?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?!.*\s).{6,24}$/;

    if (password == "") {
        document.getElementById("password").style.border = "solid red 1px";
        document.getElementById("errorpassword").style.color = "red";
        document.getElementById("errorpassword").innerHTML = "*Passwors is empty";
    }
    else if (!passwordRegex.test(password)) {
        document.getElementById("password").style.border = "solid red 1px";
        document.getElementById("errorpassword").style.color = "red";
        document.getElementById("errorpassword").innerHTML = "*Login is not valid";
    }
    else {
        document.getElementById("password").style.border = "solid grey 1px";
        document.getElementById("errorpassword").innerHTML = " ";
        console.log("good password");
    }
}
