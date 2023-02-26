const liczba = parseInt(prompt("podaj liczbę"));
const tekst = prompt("podaj tekst: ");
const myDiv = document.querySelector("#tekst");

if (isNaN(liczba)) {
    alert("podaj prawidłową liczbę");
} else {
    if (liczba > 0 ){
        if (liczba < 100) {
            for (let i = 1; i <= liczba; i++) {
                myDiv.innerHTML += `<li><a> ${tekst} ${i} </a></li>`
            }
        } else {
            alert("liczba musi być mniejsza niż sto")
        }
    } else {
        alert("liczba musi być dodatnia");
    }
}
