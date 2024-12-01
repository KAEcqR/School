<?php
$name = ($_GET['name']);
var_dump($name);
if($name == '') {
    header('Location: index.php');
    exit();
}

function getConnection(): ?mysqli
{
    $conn = new mysqli('localhost', 'root',
    null, '3tip_arkusz1');
    if($conn->connect_errno!=0) return null;
    return $conn;
}

$conn = getConnection();
if($conn==null) return;
$sql = "UPDATE zdjecia SET polubienia = polubienia + 1 WHERE tytul = '{$name}'";
echo $sql;
$conn->query($sql);
$conn->close();

header('Location: index.php');