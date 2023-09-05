console.log("jquery: ", $(document));
console.log("js: ", document)
$(document).ready(
    ()=>console.log("Hello")
)
$(()=>console.log("Hello2"))

console.log("p: ", document.querySelector("p"))
const p1 = document.querySelector("p")
console.log(p1.innerHTML)

console.log("p w JQuery:", $("p"))
const p2 = $("p")
console.log