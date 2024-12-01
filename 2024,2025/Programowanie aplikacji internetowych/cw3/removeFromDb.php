<?php
require_once 'functions.php';
$id = ($_GET['id']);
var_dump($id);
if($id == '') {
    header('Location: index.php');
    exit();
}
removeProductFromDb($id);
header('Location: index.php');