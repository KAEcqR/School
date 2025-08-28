<?php
function getConnection(): ?mysqli
{
    $conn = new mysqli('localhost', 'root',
    null, 'grzyb_kacper');//wywołanie konstruktora klasy mysqli
    if($conn->connect_errno!=0) return null;
    return $conn;
}
function getGrzyby():array {
    $conn = getConnection();
    if($conn==null) return [];
    $sql = "SELECT nazwa_pliku, potoczna FROM grzyby WHERE jadalny = 1";
    $result = $conn->query($sql);
    $wycieczki = [];
    while($row = $result->fetch_row()){
        $wycieczki[] = $row;
    }
    $conn->close();
    return $wycieczki;
}
