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
            <h3>Dane osobowe</h3>
        <table>
            <tr>
                <th>Id</th>
                <th>Nazwisko</th>
                <th>Imie</th>
                <th>PESEL</th>
            </tr>
            <?php
                include_once("functions.php");
                $pracownicy = getPracownicy(); 
                foreach ($pracownicy as $p) {
                    echo "<tr>";
                    echo "<td>{$p[0]}</td>";
                    echo "<td>{$p[1]}</td>";
                    echo "<td>{$p[2]}</td>";
                    echo "<td>{$p[3]}</td>";
                    echo "</tr>";
                }
            ?>
        </table>
        </div>
    </div>
    <div class="footer">
        <p>Autor strony: xxxxxxxxxxxx</p>
    </div>
</body>
</html>