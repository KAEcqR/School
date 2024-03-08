<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>
<body>
    <h1>Funckja message</h1>
    <?php 
        function message(int $count, string $text):string{
            $odpowiedz = "";
            for($i=0;$i<$count;$i++){
                $odpowiedz . $text;
            }
            return $odpowiedz;
        }
        echo Message(5, "Kacper")
    ?>
</body>
</html>