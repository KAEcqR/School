const contacts = [
    ["Adam", "Nowak","adan@op.pl","123456789"],
    ["Franek", "Banek","franb@op.pl","987654321"],
    ["Roman", "Boman","romb@op.pl","432156789"],
    ["Elżbieta", "Małecka","elżm@op.pl","123459876"],
    ["Dorota", "Beryk","dorb@op.pl","127654389"],
    ["Jurek", "Kiełbaslka","jurk@op.pl","127654389"],
]

console.log(contacts[2][0], contacts[2][1]);

document.querySelector("#info").innerHTML = generTab(contacts);

function generTab(tab){
    let html = "<table>";
    html += "<tr><th>Lp</th><th>Imię</th><th>Nazwisko</th><th>Email</th><th>Telefon</th></tr>";
    
    for(let i=0; i<tab.length; i++){
        html += `<tr>
                    <td>${i+1}</td>
                    <td>${tab[i][0]}</td>
                    <td>${tab[i][1]}</td>
                    <td>${tab[i][2]}</td>
                    <td>${tab[i][3]}</td>
                </tr>`
    }

    return html + "</table>";
}