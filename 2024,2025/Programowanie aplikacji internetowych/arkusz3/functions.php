<?php
function getConnection(): ?mysqli
{
    $conn = new mysqli('localhost', 'root',
    null, '3tip_arkusz2');//wywołanie konstruktora klasy mysqli
    if($conn->connect_errno!=0) return null;
    return $conn;
}
function getWycieczkiNieDostepne():array {
    $conn = getConnection();
    if($conn==null) return [];
    $sql = "SELECT dataWyjazdu, cel FROM wycieczki WHERE dostepna = 0";
    $result = $conn->query($sql);
    $wycieczki = [];
    while($row = $result->fetch_row()){
        $wycieczki[] = $row;
    }
    $conn->close();
    return $wycieczki;
}

function getWycieczkiDostepne():array {
    $conn = getConnection();
    if($conn==null) return [];
    $sql = "SELECT dataWyjazdu, cel FROM wycieczki WHERE dostepna = 1";
    $result = $conn->query($sql);
    $wycieczki = [];
    while($row = $result->fetch_row()){
        $wycieczki[] = $row;
    }
    $conn->close();
    return $wycieczki;
}


function getZdjecia():array {
    $conn = getConnection();
    if($conn==null) return [];
    $sql = "SELECT nazwaPliku, podpis FROM zdjecia;";
    $result = $conn->query($sql);
    $zdjecia = [];
    while($row = $result->fetch_row()){
        $zdjecia[] = $row;
    }
    $conn->close();
    return $zdjecia;
}