<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>
<body>
    <?php
    if(isset($_POST['firstname'])){
        var_dump($_POST);
        $firstname = trim($_POST['firstname']);
        $lastname = trim($_POST['lastname']);
        $date = trim($_POST['birthday']);
        if(!empty($firstname) && !empty($lastname) && !empty($data)){
            echo <<< Text

            <div class="info">
            <p>Imie: {$firstname} </p>
            <p>Nazwisko: {$lastname} </p>
            <p>Data: {$data} </p>
            </div>
Text;
        }
    }else{
        echo '<p> brak danych </p>';
    }
    
    ?>
</body>
</html>