class PrimalGenerator{
    constructor(limit=20){
        this.limit = limit
    }
    isPrimal(numberToCheck){
        if(numberToCheck<2) return false
        for(let i = 2; i * i <= numberToCheck; i++){
            if(numberToCheck % i == 0) return false
        }
        return true
    }
    getPrimalList(){
        const primals = []
        let n = 2
        while(primals.length < this.limit){
            if(this.isPrimal(n)){
                primals.push(n)
            }
            n++
        }
        return {"list":primals, "text":html}
    }
}

function getPersonObject(firstname,lastname, age){

}

function getPersonArray(firstname,lastname, age){

}


$("#gener").click(()=>{
    $n = $("#n")
    const generator = new PrimalGenerator($n.val())
    const primes = generator.getPrimalList();
    // primes.forEach((e) => {
    //     $("#result").html($("#result").html()+` e`)
    // })
    console.log(primes)
    $("#result").html(primes[1])
    console.log(generator.getPrimalObject().list)    
    $("#result").html(generator.getPrimalObject().text)
})