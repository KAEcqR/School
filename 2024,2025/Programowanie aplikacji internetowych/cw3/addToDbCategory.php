<?php
if($_SERVER['REQUEST_METHOD'] == 'POST') {
    require_once 'functions.php';
    $kategoria = trim(filter_input(INPUT_POST, 'kategoria'));
    $opis = trim(filter_input(INPUT_POST, 'opis'));
    var_dump($kategoria, $opis);
    if($kategoria == '' || $opis == '') {
        header('Location: kategorie.php');
        exit();
    }
    saveCategoryToDb($kategoria, $opis);
    header('Location: kategorie.php');
} else {
    echo 'Niepoprawne dane';
}