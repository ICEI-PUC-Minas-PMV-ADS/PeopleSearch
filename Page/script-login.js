function Entrar(){

    var email = document.getElementById('email').value;
    var password = document.getElementById('password').value;

    if(email == "admin" && password == "admin"){
        alert('Sucesso');
    }else{
        alert('Usuário ou senha inválido');
    }
}
