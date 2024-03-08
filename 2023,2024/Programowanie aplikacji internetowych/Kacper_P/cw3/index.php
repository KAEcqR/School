<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>
<body>
    <h1>Dodawanie: </h1>
    <?php 
        $sum = 0;
        const RANGE = 100;
        while($sum < RANGE) {
            $random = rand(0,20);
            echo $random . " + ";
            $char = $sum < RANGE ? ' + ' : ' = ';
            $sum += $random;
        };
        echo " = {$sum} <br />"
    ?>
</body>
</html>