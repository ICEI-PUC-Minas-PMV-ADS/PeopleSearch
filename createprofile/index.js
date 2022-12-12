let nome = document.getElementById("name-input");
let about = document.getElementById("about-input");
let whatSearch = document.getElementById("search-input");
let user;
let insights = [];

document.querySelector("#submit-input").onclick = function userInput() {
   user = {
    nomeValue: nome.value,
    aboutValue: about.value,
    whatSearchValue: whatSearch.value,
  }
}



document.getElementById("btt-submit").onclick = function() {
  
  insights.push(document.getElementById("insight-input").value);
  
  if (insights.length > 6) {
    document.getElementById("lenghtError").innerHTML = "Por favor Insira apenas 6 caracteristicas!"
  } else if (insights.length < 6) {
    document.getElementById("lenghtError").innerHTML = "Por favor Insira no mínimo 6 caracteristicas!"
  } else {
    document.getElementById("lenghtError").innerHTML = "Tudo certo!"
  }
  console.log(insights);  
}
  
  






  

