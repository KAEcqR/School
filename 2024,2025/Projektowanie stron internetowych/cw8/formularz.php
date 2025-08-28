<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
    <link rel="stylesheet" href="style.css">
</head>
<body>
    <div class="banner">
        <h1>Dane osobowe pracownikow</h1>
    </div>
    <div class="main">
        <div class="left">
            <ul>
                <li><a href="index.php">Wyswietl dane</a></li>
                <li><a href="formularz.php">Wpisz dane</a></li>
            </ul>
        </div>
        <div class="right">
            <h3>Podaj dane</h3>
            <form action="formularz.php" method="POST">
                <label for="nazwisko">Nazwisko : </label><br>
                <input type="text" name="nazwisko" id=""><br>
                <label for="imie">Imie : </label><br>
                <input type="text" name="imie" id=""><br>
                <label for="pesel">PESEL : </label><br>
                <input type="text" name="pesel" id=""><br>

                <button type="submit">Sprawdz i zapisz</button>
            </form>

            <?php
                if ($_SERVER['REQUEST_METHOD'] === 'POST') {
                    echo "<hr>";
                    include_once("functions.php");
                    echo "<hr>";
                }
            ?>
        </div>
    </div>
    <div class="footer">
        <p>Autor strony: xxxxxxxxxxxx</p>
    </div>
</body>
</html>