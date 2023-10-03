let inputNumber = document.querySelector('#numer')
inputNumber.style.backgroundColor = `white`;
let button = document.querySelector('#button')
let allOfTd = document.querySelectorAll("td")


inputNumber.addEventListener("input", () => {
    console.log("change")
    inputNumber.style.backgroundColor = `white`;
    let values = inputNumber.value
    if (isNaN(values)) {
        inputNumber.style.backgroundColor = `red`;
    }
})

button.addEventListener('click', () => {

    let values = inputNumber.value

    if (values <= 360 && values > 0) {

        inputNumber.style.backgroundColor = `white`;

        let allOfTd = document.querySelectorAll("td")
        allOfTd[0].style.backgroundColor = `hsl(${values}, 100%, 50%)`
        allOfTd[1].style.backgroundColor = `hsl(${values}, 80%, 50%)`
        allOfTd[2].style.backgroundColor = `hsl(${values}, 60%, 50%)`
        allOfTd[3].style.backgroundColor = `hsl(${values}, 40%, 50%)`
        allOfTd[4].style.backgroundColor = `hsl(${values}, 20%, 50%)`
    }
})
