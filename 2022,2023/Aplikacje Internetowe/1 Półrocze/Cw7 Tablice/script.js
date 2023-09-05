const t1 = [1,4,5,6,8,"ala",true];    
document.querySelector("#c1").innerHTML = t1;
let html = "<ul>";  
for(let i=0;i<t1.length; i++) {
    html += `<li>${t1[i]}</li>`
}
html += "</ul>";
document.querySelector("#c2").innerHTML = html;

t1.forEach(function(v,i){
    console.log(`i= ${i} v= ${v}`);
});

for(let elem of t1){
    console.log(elem);
}

t1.unshift("pierwszy");
t1.push("ostatni");
document.querySelector("#c3").innerHTML = t1;
console.log(t1);
t1.shift();
console.log(t1);
console.log(t1.slice(2, 4));
t1.splice(1, 0, 'kot');
console.log(t1);

console.log(t1[2]);
console.log(t1.length);