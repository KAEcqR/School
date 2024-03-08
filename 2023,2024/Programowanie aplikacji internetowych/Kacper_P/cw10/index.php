<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
    <link rel="stylesheet" href="style.css">
</head>
<body>
<form method="post" action="result.php">
        <div class="line">
            <label for="a">Podaj a: </label>
            <input type="number" name="a" id="a">
        </div>
        <div class="line">
            <label for="b">Podaj b: </label>
            <input type="number" name="b" id="b">
        </div>
        <div class="line">
            <label for="wyb">Wybierz dzialanie:</label>
            <select id="wyb" name="wyb">
                <option value="dod">Dodawanie</option>
                <option value="odj">Odejmowanie</option>
                <option value="mno">Mnozenie</option>
                <option value="dzi">Dzielenie</option>
            </select> 
        </div>
        <div class="line">
            <input type="submit" value="Zapisz" id="button"></input>
            <input type="reset" value="Wyczysc" id="button"></input>
        </div>
    </form>

    <?php

    ?>
</body>
</html>