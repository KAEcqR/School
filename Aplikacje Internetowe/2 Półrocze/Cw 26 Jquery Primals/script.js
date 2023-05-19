class PrimalGenerator{
    constructor(limit=20){
        this.limit = limit;
    }
    isPrimal(numberToCheck){
        if(numberToCheck<2) return false;
        for(let i = 2; i * i <= numberToCheck;i++){
            if(numberToCheck % i == 0) return false;
        }
        return true;
    }
    GetPrimalList(){
        const primals = [];
        let n = 2;
        let html = "";
        while(primals.length<this.limit){
            //debugger
            if(this.isPrimal(n)){
                primals.push(n)
                html += n+ " ";
            }
            n++;
        }
        return [primals,html];
    }
    GetPrimalObject(){
        const primals = [];
        let n = 2;
        let html = "";
        while(primals.length<this.limit){
            //debugger
            if(this.isPrimal(n)){
                primals.push(n)
                html += n+ " ";
            }
            n++;
        }
        return {"list":primals,"text":html};
    }
}

function GetPersonObject(firstname,lastname,age){
        //zwraca obiekt z 3 polami 
        return {fname:firstname,lname:lastname,a:age}
}
function GetPersonArray(firstname,lastname,age){
    //zwraca tablice z 3 elemetami 
    return [firstname,lastname,age]
}
$("#gener").click(()=>{
    //alert("dffdfdfdf");
    $n = $("#n");
    $("#result").html("");
    const generator = new PrimalGenerator($n.val());
    const primes = generator.GetPrimalList();
    // primes.forEach((e)=>{
    //     $("#result").html($("#result").html()+" "+e);
    // });
    console.log(primes);
    $("#result").html(primes[1]);
    console.log(generator.GetPrimalObject().list);
    $("#result2").html(generator.GetPrimalObject().text)
});
function Gg(secret){
    console.log(`Mój sekret to: ${secret}`);
    return "Jego wersja";
}
function GetSecret(){
   // return Gg("ala ma kota");
    return (()=>{Gg("ala ma kota")});
}
console.log(GetPersonObject("Adam","Nowak",45));
console.log(GetPersonArray("Adam","Nowak",45));
Gg("Rybka");
const efekt = GetSecret();
$("#result3").html(efekt());
//GetSecret()();