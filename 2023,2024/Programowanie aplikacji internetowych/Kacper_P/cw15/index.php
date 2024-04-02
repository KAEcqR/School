<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>
<body>
    <form method="post">
        <div class="row m-2">
            <label for="text" class="col-3">Podaj tekst do zaszyfrowania</label>
            <textarea name="text" id="text" class="col-3" cols="30" rows="10"></textarea>
        </div>
        <div class="row m-2">
            <label for="klucz">Klucz szyfrowania:</label>
            <input type="number" name="klucz" id="klucz" required>
        </div>
        <input type="submit" value="Submit" name ="submit" class="btn btn-primary btn-lg btn-block">
    </form>
    <?php 
        include_once("functions.php");
    ?>
</body>
</html>