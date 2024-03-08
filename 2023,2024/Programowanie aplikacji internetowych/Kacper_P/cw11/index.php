<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
    <link rel="stylesheet" href="style.css">

</head>
<body>
    <pre>
    <?php
        function Random(int $ile){
            $numbers = [];
            while(count($numbers) <= $ile){
                $number = rand(0,100);
                if(CheckPrime($number)){
                    $numbers[] = $number; 
                }
            }
            print_r($numbers);
            return $numbers;
        }

        Random(10);

        function CheckPrime($num):bool
        {
            if ($num < 2)
            return false;
            for ($i = 2; $i <= $num/2; $i++)
            {
                if ($num % $i == 0)
                return false;
            }
            return true;
        }
        

        // print_r(Random(10));
    ?>
    </pre>
</body>
</html>