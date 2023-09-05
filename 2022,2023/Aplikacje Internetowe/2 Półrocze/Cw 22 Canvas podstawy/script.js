const draw_sq = document.querySelector("#draw_sq")
draw_sq.addEventListener("click", (e)=>{
    const canvas = document.querySelector(".scene")  
    const ctx = canvas.getContext("2d");
    const info = document.querySelector(".info")
    const color = document.querySelector("#color").value
    const width = document.querySelector("#width").value
    const height = document.querySelector("#height").value
    
    const x = document.querySelector("#x").value
    const y = document.querySelector("#y").value

    if(x < canvas.offsetWidth && y < canvas.offsetHeight){
        // ctx.fillRect(x,y,width,height)
        ctx.beginPath()

        ctx.lineWidth = "1";
        ctx.strokeStyle = color;
        ctx.rect(x,y,width,height)
        ctx.stroke();
        document.querySelector(".x").style.color = "white"
        document.querySelector(".y").style.color = "white"
    } else {
        document.querySelector(".x").style.color = "red"
        document.querySelector(".y").style.color = "red"
    }
    
})

const draw_ck = document.querySelector("#draw_ck")
draw_ck.addEventListener("click", (e)=>{
    const canvas = document.querySelector(".scene")  
    const ctx = canvas.getContext("2d");
    const info = document.querySelector(".info")
    const color = document.querySelector("#color").value
    const width = document.querySelector("#width").value
    const height = document.querySelector("#height").value
    const x = document.querySelector("#x").value
    const y = document.querySelector("#y").value

    if(x < canvas.offsetWidth && y < canvas.offsetHeight){
        ctx.beginPath()
        ctx.arc(x,y,width,0,Math.PI*2,true)
    
        ctx.lineWidth = "2";
        ctx.strokeStyle = color;
        ctx.stroke();
        document.querySelector(".x").style.color = "white"
        document.querySelector(".y").style.color = "white"

    } else {
        document.querySelector(".x").style.color = "red"
        document.querySelector(".y").style.color = "red"
    }

})


//* WALIDACJA X I Y > 180