function login(event) {
    event.preventDefault();
    let data = {
        email: document.getElementById("email").value,
        password: document.getElementById("password").value
    }
    axios.post("https://localhost:7054/api/User",data)
        .then(response => {
            if (response.status == 200)
                Window.alert("Usuario Logado")
            else {
                Window.alert("Credenciais invalidas")
            }
        })
        .catch(err => console.log(err))

}