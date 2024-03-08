<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
    <link rel="stylesheet" href="style.css">
</head>
<body>
    <form method="post" action="functions.php">
        <div class="line">
            <label for="firstname">Podaj imie: </label>
            <input type="text" name="firstname" id="firstname">
        </div>
        <div class="line">
            <label for="lastname">Podaj Nazwisko: </label>
            <input type="text" name="lastname" id="lastname">
        </div>
        <div class="line">
            <label for="data">Podaj Date Urodzenia: </label>
            <input type="date" name="data" id="data">
        </div>
        <div class="line">
            <input type="submit" value="Zapisz" id="button"></input>
            <input type="reset" value="Wyczysc" id="button"></input>
        </div>
    </form>
    <?php 
        include "functions.php";
        if(isset($_POST["submit"])){
            $dane = GetFromPost();
        }
    ?>

</body>
</html>