<?php
if($_SERVER['REQUEST_METHOD'] == 'POST') {
    require_once 'functions.php';
    $nazwa = trim(filter_input(INPUT_POST, 'nazwa'));
    $opis = trim(filter_input(INPUT_POST, 'opis'));
    $cena = trim(filter_input(INPUT_POST, 'cena'));
    $category = trim(filter_input(INPUT_POST, 'category'));
    var_dump($nazwa, $opis, $cena);
    if($nazwa == '' || $opis == '' || $category == '' || $cena == '') {
        header('Location: index.php');
        exit();
    }
    saveProductToDb($nazwa, $opis, $category, $cena);
    header('Location: index.php');
} else {
    echo 'Niepoprawne dane';
}