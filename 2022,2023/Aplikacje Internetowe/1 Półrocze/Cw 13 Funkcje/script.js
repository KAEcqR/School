//funkcja zwyczajna

MyFunction1("ala ma kota", true);

//argumenst to tablica ktora zawiera aktualnie uzte argumenty przy wywoływaniu funkcji

//przy użyciu const nie można użyć funkcji przed jej zdefiniowaniem

const MyFunction2 = function(a){
    console.log(arguments);
    return a + 20;
}

console.log(MyFunction2(100, 78, "fdslfjsld"));

//javascript przy przygotowywaniu skryptu automatycznie
//przenosi definicje funkcji na początek skryptu

function MyFunction1(arg1, arg2){
    console.log(arguments)
    console.log(arg1, arg2);
}

//funkcje strzałowe

const MyFunction3 = (a, b) => {return a + b};

console.log(MyFunction3("ala", "kot"));