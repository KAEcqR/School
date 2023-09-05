class Book {
    constructor(id,image, author, year, price, description) {
        this.id  = id;
        this.title = this.GetTitle(image);
        this.image = image;
        this.author = author;
        this.year = year;
        this.price = price;
        this.description = description;
    }

    GetTitle(image) {
        return image.substring(0, image.lastIndexOf('.'));
    }

    BookToCard(){
        //* TWORZĘ KARTĘ
        const card = document.createElement("div");
        card.id = this.id;
        card.className = "card m-2";
        card.style.width = "250px";
        
        //* TWORZĘ TYTUŁ KARTY
        
        const cardTitle = document.createElement("div");
        cardTitle.className = "card-title text-center fw-bold";
        cardTitle.innerHTML = this.title;
        card.appendChild(cardTitle);

        //* USTAWIAM OBRAZEK KARTY

        const cardImage = document.createElement("img");
        cardImage.src = 'img/'+this.image;
        cardImage.className = 'cardimage'
        card.appendChild(cardImage);

        //* TWORZĘ BODY DLA KARTY

        const cardBody = document.createElement("div");
        cardBody.className = "card-body";
        cardBody.innerHTML = `<div>Cena: ${this.price} zł </div>
        <div>Autor: ${this.author}</div><div>Rok wydania: ${this.year}</div>`;
        card.appendChild(cardBody);
        
        return card;
    }
}

const ceny = [];

function GenerBook() {
    const books = [];
    booksInfo.forEach((v, i) => {
        books.push(new Book(`id_${i}`,v[0], v[1], v[2], v[3], v[4]))
        ceny.push(v[3])
    });
    return books;
}

const booksInfo = [
    ["C++ Zbiór zadań.jpg", "Antoni Małecki", 2021, 67.90, "Autor tego zbioru zadań jest programistą i nauczycielem. To prawdziwy pasjonat programowania ― w tym w języku C++ ― które traktuje jak przedłużenie ludzkiej mowy. Uważa, że praktycznie na wszystko, co robimy w życiu, można spojrzeć jak na wykonywanie funkcji i algorytmów, które opisujemy za pomocą słów."],
    ["Czysty agile.jpg", "Roman Bałecki", 2019, 45.90, "Ta książka jest bardzo potrzebnym powrotem do podstaw Agile. Przyda się nowemu pokoleniu programistów, nieprogramistów i osób, które kierują zespołami. Znalazł się tu jednoznaczny opis sedna Agile jako prostej i spójnej koncepcji zwinnego zarządzania małym projektem w niewielkim zespole."],
    ["Czysty kod.jpg", "Roman Bałecki", 2019, 89.90, "W książce Czysty kod. Podręcznik dobrego programisty szczegółowo omówione zostały zasady, wzorce i najlepsze praktyki pisania czystego kodu. Podręcznik zawiera także kilka analiz przypadków o coraz większej złożoności, z których każda jest doskonałym ćwiczeniem porządkowania zanieczyszczonego bądź nieudanego kodu."],
    ["Kompetentny.jpg", "Roman Bałecki", 2017, 69.90, "Przewodnik, który trzymasz w ręku, powstał właśnie po to, by zasypać otchłań między działem HR i pozostałymi dywizjami organizacji w procesie transformacji. Kate ma nadzieję, że dzięki książce uda jej się pomóc zarówno osobom przeprowadzającym transformację, jak i działom HR firm i organizacji."],
    ["Motywacja pod lupą.jpg","Roman Bałecki", 2019, 45.90, "Jeśli rozumie, czym jest i jak działa skuteczne motywowanie pracowników - na pewno. Ta książka, której trzecie, rozszerzone wydanie trzymasz w rękach, może być w tej kwestii bardzo pomocna. Powstała bowiem na podstawie doświadczeń jej autorów i uczestników szkoleń menedżerskich, które autorzy prowadzili i prowadzą. Bazuje więc na realiach pracy w różnych firmach i rozmaitych branżach, co czyni ją tym bardziej wartościową pozycją."],
    ["Pełna moc.jpg","Roman Bałecki", 2019, 45.90, "Psycholog, mówca, trener i mentor, którego szeroki świat internetu poznał ― i którym się zachwycił ― dziesięć lat temu. We wrześniu 2012 roku Jacek Walkiewicz opowiedział słuchaczom TEDxWSB we Wrocławiu, w czym tkwi pełna moc naszych możliwości."],
    ["Podstawy matematyki.jpg", "Roman Bałecki", 2022, 33.90, "To książka przeznaczona dla osób, które chcą dobrze zrozumieć matematyczne podstawy nauki o danych i nauczyć się stosowania niektórych koncepcji w praktyce. Wyjaśniono tu takie zagadnienia jak rachunek różniczkowy i całkowy, rachunek prawdopodobieństwa, algebra liniowa i statystyka, pokazano także, w jaki sposób posługiwać się nimi w regresji liniowej, regresji logistycznej i w tworzeniu sieci neuronowych."],
];

const books = GenerBook();
const bookDiv = document.querySelector(".books");
books.forEach((v,i)=>{
    bookDiv.appendChild(v.BookToCard());
});

const info = document.querySelector(".info");
const info2 = document.querySelector(".info2");
const cards = document.querySelectorAll(".card");

cards.forEach((v,i)=>{
    v.addEventListener("mouseenter",(event)=>{

        const book = books.filter((b)=>{
            return b.id===v.id;  
        });

        info.innerHTML = 
        `<h3>Wybrana książka:</h3> Tytuł: <span class='content'>${book[0].title}</span><br>
         Autor: <span class='content'>${book[0].author}</span><br>
         Cena: <span class='content'>${book[0].price} zł</span><br>
         Opis: <span class='content'>${book[0].description}</span>`;

        info2.innerHTML = 
        `<h3>Maksymalna cena</h3> ${getMax(ceny)} zł</span>
         <h3>Minimalna cena</h3> ${getMin(ceny)} zł</span>
         <h3>Średnia cena</h3> ${getAvg(ceny)} zł</span>`;
    });
    v.addEventListener("mouseleave",(event)=>{
        info.innerHTML = "";
    });
})

getTotal(books)

function getMax(array){
    let wynik = (Math.max(...array));
    return wynik;
}

function getMin(array){
    let wynik = (Math.min(...array));
    return wynik;
}

function getAvg(){
    let wynik = getTotal(books) / ceny.length ;
    wynik = parseFloat(wynik).toFixed(2)
    return wynik
}

function getTotal(books){
    total = 0;
    books.forEach((v,i)=>{
        total += v.price;
    })
    console.log(total)
    return total;
}

const infobutton = document.querySelector (".infobutton")
let infobuttonState = 1
infobutton.addEventListener("click", ()=>{
    if(infobuttonState % 2 == 1) {
        info.style.display = "none"
        info2.style.display = "none"
        console.log("włączone")
        infobutton.innerHTML = `<img src="img/open.png">`
        infobuttonState += 1;
    } else {
        info.style.display = "block"
        info2.style.display = "block"
        console.log("wyłączone")
        infobutton.innerHTML = `<img src="img/cross.png">`
        infobuttonState += 1;
    }

})