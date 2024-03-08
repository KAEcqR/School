<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>
<body style="margin: 0; padding:0;" > 
    <div class="container" style=" width: 100%; height: 100vh;">

    </div>
    <?php 
        $tablica = ["czerwony"=>"red", "niebieski"=>"blue", "zielony"=>"green"];

        echo "<select id='kolorki' style='position: absolute; left: 0; top: 0;'>";
        foreach($tablica as $value){
            echo "<option value='$value'>" ;
            echo $value;
            echo "</option>:";
        }
        echo "</select>";
    ?>
    <script src="script.js"></script>
</body>
</html>