let wrapper = document.querySelector(".wrapper");

let zyczenia = [`Świąt prawdziwie świątecznych,
ciepłych w sercu,
zimowych na zewnątrz
jaśniejących pierwszą gwiazdką,
co daje nadzieję na następny Rok`, 
`Dużo szczęścia, zdrowia i powodzenia,
To tradycyjne, najszczersze życzenia.
Wesołych Świąt i Roku Szczęśliwego.
Niech obficie da, co ma najlepszego!`, 
`Niech magiczna moc
Wigilijnego Wieczoru
przyniesie spokój i radość.
A Nowy Rok obdaruje
pomyślnością i szczęściem.
Najpiękniejszych Świąt Bożego Narodzenia
oraz Szczęśliwego Nowego Roku życzy`]

function dodaj(){
    let html = '';
    let i = 0;

    zyczenia.forEach(e => {
        html += '<p>' 
        html += zyczenia[i]
        html += '</p>'
        i++; 
        console.log(html)
    });

    wrapper.innerHTML = html;
}

dodaj()