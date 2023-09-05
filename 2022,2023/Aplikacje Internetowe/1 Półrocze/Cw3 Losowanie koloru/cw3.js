//function Hello(text){
//    console.log("from hello()");
//    return "Hello: "+text;
//}
//document.querySelector("#info").innerHTML = Hello("Franek");
//
// const a = parseFloat(prompt("podaj a:"));
// const b = parseFloat(prompt("podaj b:"));
const element = document.querySelector("#info4");
console.log(element);
if(element != null){
    setInterval(function(){
        changeColor(element);
    },200);
}
//Add("#info3",a,b);
function Add(selector,liczba1,liczba2){
    const elem = document.querySelector(selector);
    if(elem==null){
        console.log("błędny selektor!!!");
        return;
    }
    elem.innerHTML = `${liczba1} + ${liczba2} = ${liczba1+liczba2}`; 
}

function changeColor(elem){
        let red = Math.floor(Math.random()*256);
        let green = Math.floor(Math.random()*256);
        let blue = Math.floor(Math.random()*256);
        console.log(red,green,blue);
        elem.style.color = `rgb(${red},${green},${blue})`;
}