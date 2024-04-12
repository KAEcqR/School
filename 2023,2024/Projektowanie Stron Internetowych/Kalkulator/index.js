var PI = 3.14;

document.getElementById("submit").addEventListener("click", ()=> {
    let r = document.getElementById("r").value;
    let pole = PI * r * r;
    document.getElementById("wynik").text = pole;
})
