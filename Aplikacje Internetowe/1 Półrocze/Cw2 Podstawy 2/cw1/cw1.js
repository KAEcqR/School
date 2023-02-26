console.log("Hello");
document.querySelector
const myDiv = document.querySelector("#info");
const myH1 = document.querySelector("h1");
console.log(myDiv);
setTimeout(function(){
    //myDiv.innerText = "ala ma kota";
    myDiv.innerHTML = "ala ma kota";
    myDiv.style.color = "red";
    myH1.style.color = "green";
},1000);
