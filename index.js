let nome = document.getElementById("name-input");
let about = document.getElementById("about-input");
let whatSearch = document.getElementById("search-input");
let user;

document.querySelector("#submit-input").onclick = function userInput(user) {
  const nomeValue = nome.value;
  const aboutValue = about.value;
  const whatSearchValue = whatSearch.value;
  user = [nome.value, about.value, whatSearch.value];
  console.log(user);
}


