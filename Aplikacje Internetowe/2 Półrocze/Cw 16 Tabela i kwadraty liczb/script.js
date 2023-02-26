//const d1 = document.createElement("div");
//d1.innerHTML = "Mój pierwszy element";

//document.body.appendChild(d1);

//const p = document.createElement("p");
//p.innerHTML = "To jest paragraf"

//const container = document.querySelector(".container")

//container.appendChild(p);

//const ol = document.createElement("ol");

//for(let i=1; i<=5; i++){
//    const li = document.createElement("li")
//    li.innerHTML = `element listy numer ${i}`
//    ol.appendChild(li)
//}
//document.body.appendChild(ol)

//const size = parseInt(prompt("Podaj liczbę w przedziale 2 do 50"))

const submit = document.querySelector(".button")

let size = document.querySelector("#size");

submit.addEventListener("click", () => {
    validate(size.value)
})

let xOK = 0;

function validate(x){
    document.querySelector(".error").innerHTML = ""
    if(!isNaN(x)){
        if(x < 51 & x >= 2){
            xOK = x;
            generateTab()
        }
        else{
            document.querySelector(".error").innerHTML = ("podaj liczbę w przedziale od 2 do 50 !")
        }
    }else{
        console.log("Podaj prawidłowa liczbę")
    }
}

function generateTab(){
    if(document.querySelector("#a69")){
        document.querySelector(`#a69`).remove()
    }

    if(document.querySelector("#a70")){
        document.querySelector(`#a70`).remove()
    }

    const container = document.querySelector(".info")
    const table = document.createElement("table")
    const list = document.createElement("ol")
    const lcontainer = document.querySelector(".lista")
    
    table.setAttribute("id", "a69")
    list.setAttribute("id", "a70")


    for(let i=1; i<=xOK; i++){
        let random = Math.floor(Math.random()*200);
        const td = document.createElement("td")
        td.innerHTML = `${random}`
        if((i-1) % 10 == 0) {
           const tr = document.createElement("tr")
           table.appendChild(tr)
        }
        table.appendChild(td)
        container.appendChild(table)

        let potega = random * random;
        const li = document.createElement("li")
        li.innerHTML = `${random} <sup> 2 </sup> = ${potega}`

        list.appendChild(li)
        lcontainer.appendChild(list)
    }

}
