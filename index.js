let nome = document.getElementById("name-input");
let about = document.getElementById("about-input");
let whatSearch = document.getElementById("search-input");
let user;

document.querySelector("#submit-input").onclick = function userInput() {
   user = {
    nomeValue: nome.value,
    aboutValue: about.value,
    whatSearchValue: whatSearch.value,
  }
  return user;
  console.log(userInput);
}
 console.log(user);

