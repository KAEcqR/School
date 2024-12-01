<?php
if($_SERVER['REQUEST_METHOD'] == 'POST') {
    require_once 'functions.php';
    $firstname = trim(filter_input(INPUT_POST, 'firstname'));
    $lastname = trim(filter_input(INPUT_POST, 'lastname'));
    $group = trim(filter_input(INPUT_POST, 'group'));
    var_dump($firstname, $lastname);
    if($firstname == '' || $lastname == '' || $group == '') {
        header('Location: index.php');
        exit();
    }
    saveStudentToDb($firstname, $lastname, $group);
} else {
    echo 'Niepoprawne dane';
}