<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>
<body>
    <h3>Tablice Superglobalne w php</h3>
    <form method="get">
        <input type="text" name="imie">
        <input type="text" name="nazwisko">
        <label for="range">Wzrost</label>
        <input type="range" min="0" max="300">
        <input type="submit" value="wyslij">
    </form>
    <pre><?php
        // var_dump($_FILES);    
        // var_dump($_SERVER);
        // var_dump($_GET);
        echo "<p>Imie : {$_GET['imie']}</p>"
    ?></pre>
</body>
</html>