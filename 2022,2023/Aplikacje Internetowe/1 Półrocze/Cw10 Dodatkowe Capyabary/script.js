const capyabara = [
  ["Capybara at work", "Pracuje", "work.png", "Biuro"],
  ["Moose capybara", "Zajada", "moose.png", "Trafka"],
  ["CApybaRa mobile", "Brum Brum", "car.png", "Ulica"],
  ["Capybara friend", "Współpracuje", "friend.png", "Zebranie"],
  ["Cool Capybara", "Gigachad", "cool.png", "Cool B)"],
  ["Hamster", "To nawet nie capybara", "hamster.png", "Brak danych"],
  ["Capybara pig", "Bekon mniam", "pig.png", "Wieś"],
];

document.querySelector("#info").innerHTML = generTab(capyabara);

function generTab(tab) {
  let html = "<table>";
  html +=
    "<tr><th>Lp</th><th>Nazwa</th><th>Czym się zajmuje</th><th>Zdjęcie</th><th>Miejsce występowania</th></tr>";

  //for(let i=0; i<tab.length; i++){
  //    html += `<tr>
  //                <td>${i+1}</td>
  //                <td>${tab[i][0]}</td>
  //                <td>${tab[i][1]}</td>
  //                <td><img src="${tab[i][2]}"></td>
  //                <td>${tab[i][3]}</td>
  //            </tr>`
  //}

  let lp = 0;
  tab.forEach(function (e, i) {
    html += `<tr>
                      <td>${++lp}</td>
                      <td>${e[0]}</td>
                      <td>${e[1]}</td>
                      <td><img src="${e[2]}"></td>
                      <td>${e[3]}</td>
            </tr>`;
  });

  return html + "</table>";
}

const tds = document.querySelectorAll("td");

tds.forEach(function (e, i) {
  e.addEventListener("click", function (event) {
    if (event.target.querySelector("img") != null) {
      console.log("zostalo nacisniete zdjecie");
      if (event.target.style.backgroundColor != "red") {
        event.target.style.backgroundColor = "red";
      } else {
        event.target.style.backgroundColor = "white";
      }
    } else {
      if (event.target.style.color != "red") {
        event.target.style.color = "red";
      } else {
        event.target.style.color = "blue";
      }
    }
  });
});
