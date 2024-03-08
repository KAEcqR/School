var option = document.querySelector("select");
let main = document.querySelector(".container");

option.addEventListener("change", ()=>{
    var odpowiedz = option.value;
    main.setAttribute("style", `background-color: ${odpowiedz}; width: 100%; height: 100vh;`);
    
})
