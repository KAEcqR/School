<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.2/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-T3c6CoIi6uLrA9TneNEoa7RxnatzjcDSCmG1MXxSR1GAsXEV/Dwwykc2MPK8M2HN" crossorigin="anonymous">
    <link rel="stylesheet" href="style.css">
</head>
<body>

    <?php 
        function wizytowka(string $imie, string $nazwisko, int $rok, string $klasa): string{
            $wizytkowa = '<div class="card" style="width: 18rem;"> <div class="card-header"> UCZEŃ <img src="user.jpg" class="card-img-top icon"> </div>  <div class="card-body"> <h5 class="card-title"> ';
            $wizytkowa.= "{$imie} </h5>";
            $wizytkowa.= "<h6 class='card-subtitle mb-2 text-body-secondary'>{$nazwisko} </h6><br>";
            $wizytkowa.="<p class='card-text'>{$rok} ";
            $wizytkowa.="{$klasa} <br>";
            $wizytkowa.="</p></div></div>";
            return $wizytkowa;
        };

        echo wizytowka("Kacper", "Prochwicz", 2023, "2TIP");
        echo wizytowka("Bodzio", "Osadziński", 2023, "2TIP");
    ?>
</body>
</html>