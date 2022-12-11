let nome = document.getElementById("name-input");
let about = document.getElementById("about-input");
let whatSearch = document.getElementById("search-input");

document.querySelector("#submit-input").onclick = function userInput() {
  const user = {
    nomeValue: nome.value,
    aboutValue: about.value,
    whatSearchValue: whatSearch.value,
  }
  
  console.log(user);
}


