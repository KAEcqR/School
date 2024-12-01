<?php
function getConnection(): ?mysqli
{
    $conn = new mysqli('localhost', 'root',
    null, '3tip_cw2');//wywołanie konstruktora klasy mysqli
    if($conn->connect_errno!=0) return null;
    return $conn;
}
function getProducts():array {
    $conn = getConnection();//pobranie połączenia
    if($conn==null) return [];//jeśli nie udało się połączyć z bazą danych to zwracamy pustą tablicę
    $sql = "SELECT * FROM produkty";//zapytanie do bazy danych
    $result = $conn->query($sql);//wykonanie zapytania
    $products = [];
    while($row = $result->fetch_row()){//pobieranie wiersza z wyniku zapytania
        $products[] = $row;//dodanie wiersza do tablicy groups
    }
    $conn->close();//zamknięcie połączenia
    return $products;
}

function getCategories():array {
    $conn = getConnection();//pobranie połączenia
    if($conn==null) return [];//jeśli nie udało się połączyć z bazą danych to zwracamy pustą tablicę
    $sql = "SELECT * FROM kategorie";//zapytanie do bazy danych
    $result = $conn->query($sql);//wykonanie zapytania
    $category = [];
    while($row = $result->fetch_row()){//pobieranie wiersza z wyniku zapytania
        $category[] = $row;//dodanie wiersza do tablicy groups
    }
    $conn->close();//zamknięcie połączenia
    return $category;
}

function getCategoryOptions(array $categories) : ?string {
    $html = '';
    foreach($categories as $c){
        $html .= "<option value='{$c[0]}'>{$c[1]}</option>";
    }
    return $html;
}

function getCategoryFromId(int $id): ?string {
    $conn = getConnection();
    if ($conn == null) return null;
    $sql = "SELECT kategoria FROM kategorie WHERE id = '$id'";
    $result = $conn->query($sql);
    if ($result) {
        $row = mysqli_fetch_row($result);
        $category = $row[0];
    }
    $conn->close();
    return $category;
}

function saveProductToDb(string $nazwa, string $opis, int $kategoriaId, int $cena) : void {
    $conn = getConnection();
    if($conn==null) return;
    $sql = "INSERT INTO produkty (nazwa, opis, kategoriaId, cena)" . "VALUES ('{$nazwa}', '{$opis}', {$kategoriaId}, {$cena})";
    $conn->query($sql);
    $conn->close();
}

function removeProductFromDb(string $id) :void {
    $conn = getConnection();
    if($conn==null) return;
    $sql = "DELETE FROM produkty WHERE id = {$id}";
    echo $sql;
    $conn->query($sql);
    $conn->close();
}

function saveCategoryToDb(string $kategoria, string $opis) : void {
    $conn = getConnection();
    if($conn==null) return;
    $sql = "INSERT INTO kategorie (kategoria, opis)" . "VALUES ('{$kategoria}', '{$opis}')";
    $conn->query($sql);
    $conn->close();
}

function removeCategoryFromDb(string $id) :void {
    $conn = getConnection();
    if($conn==null) return;
    $sql = "DELETE FROM kategorie WHERE id = {$id}";
    echo $sql;
    $conn->query($sql);
    $conn->close();
}

function removeCategoryWithProducts(string $id){
    $conn = getConnection();
    if($conn==null) return;
    $sql = "DELETE produkty FROM produkty INNER JOIN kategorie ON produkty.kategoriaId = kategorie.id WHERE kategorie.id = {$id}";
    echo $sql;
    $conn->query($sql);
    $conn->close(); 
    removeCategoryFromDb($id);
}