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
    
    ctx.beginPath()
    // ctx.fillRect(25,25,50,50)
    ctx.lineWidth = "1";
    ctx.strokeStyle = color;
    ctx.rect(x,y,width,height)
    ctx.stroke();
    
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

    ctx.beginPath()
    ctx.arc(x,y,width,0,Math.PI*2,true)
    
    ctx.lineWidth = "2";
    ctx.strokeStyle = color;
    ctx.stroke();
    // console.log("kolo")
    
})