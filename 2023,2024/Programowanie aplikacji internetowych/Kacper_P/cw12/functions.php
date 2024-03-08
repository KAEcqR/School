<?php

use function PHPSTORM_META\type;
function getFromPost(): ?array {
    $firstname = trim($_POST['firstname']);
    $lastname = trim($_POST['lastname']);
    $data = $_POST['data'];
    
    if (!empty($firstname) || !empty($lastname) || $data != 0 || strlen($firstname) > 3 || strlen($lastname) > 3) {
        $wiek = explode('-', $data);
        $age =  intval(date("Y")) - intval($wiek[0]); 
        return [$firstname, $lastname, $data, $age];
    }
    
    return null;
}

function showInfo(?array $daty): void {
    echo ' IMIE: '. $daty[0] . "<br>";
    echo ' NAZWISKO: ' . $daty[1]. "<br>";
    echo ' DATA URODZENIA: ' . $daty[2]. "<br>"; 
    echo ' WIEK: ' . $daty[3]. "<br>";
}


showInfo(getFromPost());
