$(document).ready(function(){

    $("#pole").click(function(){        
        let a = $("#a").val();
        let b = $("#b").val();

        if($.isNumeric(a));
        let pole = a * b;

        $("#wynik").html(pole)
    })

})
