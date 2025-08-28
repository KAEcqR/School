<?php

function getConnection(): ?mysqli {
    $conn = new mysqli('localhost', 'root', null, 'firma');
    if ($conn->connect_errno != 0) return null;
    return $conn;
}

function getPracownicy(): array {
    $conn = getConnection();
    if ($conn == null) return [];
    $sql = "SELECT * FROM pracownicy";
    $result = $conn->query($sql);
    $pracownicy = [];
    while ($row = $result->fetch_row()) {
        $pracownicy[] = $row;
    }
    $conn->close();
    return $pracownicy;
}

function SumaKontrolna(string $pesel): bool {
    if (!preg_match('/^\d{11}$/', $pesel)) return false;

    $weights = [1, 3, 7, 9, 1, 3, 7, 9, 1, 3];
    $sum = 0;

    for ($i = 0; $i < 10; $i++) {
        $sum += $weights[$i] * intval($pesel[$i]);
    }

    $controlDigit = (10 - ($sum % 10)) % 10;

    return $controlDigit == intval($pesel[10]);
}

if ($_SERVER['REQUEST_METHOD'] === 'POST') {
    $imie = trim(filter_input(INPUT_POST, 'imie'));
    $nazwisko = trim(filter_input(INPUT_POST, 'nazwisko'));
    $pesel = trim(filter_input(INPUT_POST, 'pesel'));

    $errors = [];

    if (empty($nazwisko)) {
        echo "<p class='nazwError'>Brak nazwiska</p>";
    }

    if (empty($imie)) {
        echo "<p class='imieError'>Brak imienia</p>";
    }

    if (empty($pesel)) {
        echo "<p class='peselError'>Brak numeru PESEL</p>";
    } elseif (!SumaKontrolna($pesel)) {
        echo "<p class='peselError'>Niepoprawny numer PESEL</p>";
    }

    if (!empty($imie) && !empty($nazwisko) && !empty($pesel) && SumaKontrolna($pesel)) {
        echo "<p class='success'>Zapisuje do bazy: <strong>$nazwisko $imie $pesel</strong></p>";

        $conn = getConnection();
        if ($conn == null) return [];
        $sql = $conn->prepare("INSERT INTO pracownicy (nazwisko, imie, PESEL) VALUES (?, ?, ?)");
        $sql->bind_param("sss", $nazwisko, $imie, $pesel);
        $sql->execute();
        $sql->close();
        $conn->close();
    }
}
?>
