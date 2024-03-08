<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>
<body>
    <h1>cwiczenie 6</h1>
    <h2>Definicja tablicy</h2>
    <pre>
        <?php 
            $t1 = [3,5,6,4,3,"ala",true,'inny napis'];
            print_r($t1);
            $t1[] = 'nowy na koncu';
            print_r($t1);
            unset($t1[8]);
            print_r($t1);
        ?>
    </pre>
</body>
</html>