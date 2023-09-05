document.querySelector(".swierko").addEventListener("click", function() {
    console.log("swierk obraz");
    document.querySelector(".swierk").style.display = "none"
    document.querySelector(".jodla").style.display = "none"
    document.querySelector(".sosna").style.display = "none"
    document.querySelector(".modrzew").style.display = "none"
    document.querySelector(".swierk").style.display = "flex"
});

document.querySelector(".jodlao").addEventListener("click", function() {
    console.log("jodla obraz");
    document.querySelector(".swierk").style.display = "none"
    document.querySelector(".jodla").style.display = "none"
    document.querySelector(".sosna").style.display = "none"
    document.querySelector(".modrzew").style.display = "none"
    document.querySelector(".jodla").style.display = "flex"
});

document.querySelector(".modrzewo").addEventListener("click", function() {
    console.log("modrzew obraz");
    document.querySelector(".swierk").style.display = "none"
    document.querySelector(".jodla").style.display = "none"
    document.querySelector(".sosna").style.display = "none"
    document.querySelector(".modrzew").style.display = "none"
    document.querySelector(".modrzew").style.display = "flex"
});

document.querySelector(".sosnao").addEventListener("click", function() {
    console.log("sosna obraz");
    document.querySelector(".swierk").style.display = "none"
    document.querySelector(".jodla").style.display = "none"
    document.querySelector(".sosna").style.display = "none"
    document.querySelector(".modrzew").style.display = "none"
    document.querySelector(".sosna").style.display = "flex"
});

