let html = "";
for(let i = 0; i < 10; i++){
    html += "<div> i= " + i + "<div>"
}

document.querySelector("#iter").innerHTML = html;

