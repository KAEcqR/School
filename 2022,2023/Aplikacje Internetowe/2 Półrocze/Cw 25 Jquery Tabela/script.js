let even = []
let button = $(".button")
let table = $("table").get(0)

even.push($('.tab td:even'));

$( "tr" ).hover(function(){
    if ($(this).index() % 2 == 0){
        $(this).addClass("highlight")
    }
},function(){
    $(this).removeClass("highlight")
});

button.click(() => {
    AddRow(table)
})

//* DODAJ DO TABELI

function AddRow(table){

    const row = table.insertRow();
    const c0 = row.insertCell(0)
    const c1 = row.insertCell(1)
    const c2 = row.insertCell(2)
    const c3 = row.insertCell(3)

    c0.innerHTML = $("#danie").val()
    c1.innerHTML = $("#czas").val()
    c2.innerHTML = $("#cena").val()
    // c3.innerHTML = $("#zdjecie").val()
    c3.innerHTML = `<img src="${$("#zdjecie").val()}">`

}
