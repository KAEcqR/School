<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>
<body>
    <?php
    include_once "functions.php";
    $text = "ala ma kota";
    $text2 = "Żółty";
    echo "<p>{$text} ma ". strlen($text) ." Znakow </p>";
    echo "<p>{$text2} ma ". strlen($text2) ." Znakow </p>";
    ?>
</body>
</html>