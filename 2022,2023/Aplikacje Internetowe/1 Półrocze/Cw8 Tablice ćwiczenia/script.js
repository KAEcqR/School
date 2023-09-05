const divs = document.querySelectorAll("div.names")
getOnlyEven(divs);
console.log(divs);

function getOnlyEven(tab){
    tab.forEach(function(e,i){
        if(i%2==0){
            console.log(e.innerHTML);
            e.style.color = "red";
        }
    })
}