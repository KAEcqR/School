const interval = parseInt(prompt("Co ile chcesz zmieniac kolor strony, podaj w ms: "))

setInterval(function(){
    changeColor();
},interval);

function changeColor(){
    let red = Math.floor(Math.random()*256);
    let green = Math.floor(Math.random()*256);
    let blue = Math.floor(Math.random()*256);
    console.log(red,green,blue);
    document.body.style.backgroundColor = `rgb(${red},${green},${blue})`;
}