document.querySelector(".scena").innerHTML = generTab(10,10);
let dif = 10;
//dif = prompt("Wpisz ile bomb ma się generować");
let score = document.querySelector(".score");
let score2 = document.querySelector(".score2")
let gameOver = 0;

for(let i=0; i < dif; i++){
    generBomb();
}

function generTab(rows, cols) {
    let html = "<table>";
    let k = 0;
    for (let i = 0; i < rows; i++) {
        html += "<tr>";
        for (let j = 0; j < cols; j++) {
            html += `<td><img src='media/p.png' id='${"a" + k}' class="0"></td>`;
            k++;
        }
        html += "</tr>";
    }

    return html + "</table>";
}

function generBomb() {
    let position = Math.floor(Math.random()*100);
    let bomb = document.querySelectorAll(`#a${position}`);
    bomb[0].src="media/p.png";
    
    bomb.forEach(function (elem, i) {
        elem.addEventListener("click", function() {
            bomb[0].src="media/bomb.png"
            document.querySelector(".saper").innerHTML = "Przegrałeś";
            console.log("bomb");
            document.querySelector(".cover").style.display = "flex";
            console.log("przegrałeś");
            gameOver = 1;
        });
    });
}

let n=0;
const tds = document.querySelectorAll("td");
tds.forEach(function (elem, i) {
    elem.addEventListener("contextmenu", function (event) {
        event.preventDefault();
        return false;
    });
    elem.addEventListener("mousedown", function (e) {               
        switch (e.buttons) {
            case 1: console.log("lewy");
                e.target.src="media/pgit.png";
                console.log(e.target)
                if(gameOver != 1){
                    if(e.target.className != 1 && e.target.querySelector("img") == null){
                        n++;
                       score.innerHTML = `Score: ${n}`;
                       score2.innerHTML = `Score: ${n}`;
                    } 
                    e.target.className = 1; 
                }
                break;
            case 2:
                console.log("prawy");
                e.target.src="media/flag.png";
                break;
            case 4:
                console.log("środkowy");
                break;
            default: console.log("inny");
        }
        
    });
});

let button = document.querySelector(".button");

button.addEventListener("click", function(){
    window.location.reload();
});

let button2 = document.querySelector(".button2");

button2.addEventListener("click", function(){
    window.location.reload();
});
