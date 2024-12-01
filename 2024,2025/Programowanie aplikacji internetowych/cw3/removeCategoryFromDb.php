<?php
require_once 'functions.php';
$id = ($_GET['id']);
var_dump($id);
if($id == '') {
    header('Location: kategorie.php');
    exit();
}
removeCategoryWithProducts($id);
header('Location: kategorie.php');