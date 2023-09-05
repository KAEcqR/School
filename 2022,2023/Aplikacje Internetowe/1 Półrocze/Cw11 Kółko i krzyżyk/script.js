document.querySelector("#run").addEventListener("click", function () {
    //console.log("click");
    widthOK = ValidateNumber(document.querySelector("#width"));
    heightOK = ValidateNumber(document.querySelector("#height"));
    if (widthOK && heightOK) {
        let cols = parseInt(document.querySelector("#width").value);
        let rows = parseInt(document.querySelector("#height").value);
        document.querySelector(".scene").innerHTML = generTab(cols, rows);
        const tds = document.querySelectorAll("td>img");
        // console.log(tds);
        document.querySelector("table").addEventListener("contextmenu", function (event) {
            event.preventDefault();
            return false;
       });
        tds.forEach(function (elem, i) {
            console.log(elem,i);
            elem.addEventListener("contextmenu", function (event) {
                console.log(event);
                event.preventDefault();
                return false;
            });
            elem.addEventListener("mousedown", function (e) {               
                console.log(e);
                
                switch (e.buttons) {
                    case 1: console.log("lewy");
                      e.target.src="media/cross.png";
                        break;
                    case 2:
                        console.log("prawy");
                        e.target.src="media/circle.png";
                         break;
                    case 4:
                        console.log("czyszczenie");
                        e.target.src="media/p.png";
                        break;
                    default: console.log("inny");
                }
              
               
                
            });
        });
    }

});


function ValidateNumber(element) {
    const next = element.nextElementSibling;
    console.log(next);
    if (!isNaN(parseInt(element.value)) && element.value >= 4 && element.value <= 100) {
        next.innerHTML = "";
        element.classList.remove("input-error");
        return true;
    } else {
        next.innerHTML = "!";
        element.classList.add("input-error");
        return false;
    }
}
function generTab(cols, rows) {
    let html = "<table>";
    for (let i = 0; i < rows; i++) {
        html += "<tr>";
        for (let j = 0; j < cols; j++) {
            html += "<td><img src='media/p.png' ></td>";
        }
        html += "</tr>";
    }

    return html + "</table>";
}