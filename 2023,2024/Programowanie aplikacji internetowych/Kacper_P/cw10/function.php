<?php

function Message(string $firstname, string $lastname, int $age):string {
    $html = "<div>";
    $html .= "Imie : {$firstname}, Nazwisko : {$lastname} wiek : {$age}";
    return $html . "</div>";
}

// echo Message("Bodzio", "Osadzinski", 0,5);

function GetAll ():array {
    return [
        ["Anna","Wanna",33],
        ["Roman","Boman",28],
        ["Anita","Wita",39],
        ["Tomasz","Bomasz",12],
        ["Filip","Bodzio", 32]
    ];
};


foreach (GetAll() as $e){
    echo Message(...$e);
}