<?php

$year = $_POST['year'];
$title = $_POST['title'];
$author = $_POST['author'];
$price = $_POST['price'];

$file = 'dane.txt';

$data = "\n$year\n$title\n$author\n$price\n";

file_put_contents($file, $data, FILE_APPEND);
header('Location: index.php');