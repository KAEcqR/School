
let result = document.querySelector(".result");
const selection = document.querySelector("#choice");
let metoda = "";

selection.addEventListener("change",(event)=> {
    metoda = event.target.value;
})    

document.querySelector("#run").addEventListener("click", () => {
    let n = parseInt(document.querySelector("#n").value);
    if(!isNaN(n)){
        switch(metoda){
            case 'rek':
            result.innerHTML = `Silnia rek z ${n} wynosi ${silniaRek(n)}`;;
            break;

            case 'iter':
            result.innerHTML = `Silnia iter z ${n} wynosi ${silniaIter(n)}`;
            break;

            case '':
            result.innerHTML = 'WYBIERZ METODĘ';
            break;
        }
    } else {
        result.innerHTML = 'BŁĘDNE DANE';
    }
})

function silniaRek(n){
    if(n<=1) return 1;
    return silniaRek(n-1)*n;
}

function silniaIter(n){
    if(n<=1) return 1;
    let result = 1;
    for(let i = 1;i <= n; i++){
        result = result * i;
    }
    return result;
}



