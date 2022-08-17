function signUp(event) {
    event.preventDefault();
    let data = {
        username: document.getElementById("username").value,
        password: document.getElementById("password").value,
        email: document.getElementById("email").value,
        confirmpassword: document.getElementById("passwordConfirm").value

    }
    axios.post("https://localhost:7054/api/User/create", data)
        .then(response => {
            if (response.status == 200)
                window.alert("Usuario Cadastrado")
            else
                window.alert("error")
        })
        .catch(err => console.log(err))

}