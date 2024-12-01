<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-QWTKZyjpPEjISv5WaRU9OFeRpok6YctnYmDr5pNlyT2bRjXh0JMhjY6hW+ALEwIH" crossorigin="anonymous">
    <link rel="stylesheet" href="style.css">
    <title>Lista produktow</title>
</head>

<body>
    <main class="container">
        <h1>Dodaj nowy produkt</h1>
        <form action="addToDb.php" method="post">
            <div class="row m-2">
                <input type="text" name="nazwa" class="col-6" placeholder="Podaj nazwe">
                <span class="col-3 text-danger"></span>
            </div>
            <div class="row m-2">
                <input type="text" name="opis" class="col-6" placeholder="Podaj opis">
                <span class="col-3 text-danger"></span>
            </div>
            <div class="row m-2">
                <label for="category" class="col-3">Wybierz kategorie</label>
                <select name="category" id="category" class="col-3">
                    <?php
                    require_once 'functions.php';
                    echo getCategoryOptions(getCategories());
                    ?>
                </select>
            </div>
            <div class="row m-2">
                <input type="number" name="cena" class="col-6" placeholder="Podaj cene">
                <span class="col-3 text-danger"></span>
            </div>
            <div class="row m-2">
                <input type="submit" value="Zapisz" class="btn btn-primary col-6">
            </div>
        </form>

    </main>
</body>
</main>

<script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/js/bootstrap.bundle.min.js" integrity="sha384-YvpcrYf0tY3lHB60NNkmXc5s9fDVZLESaAA55NDzOxhy9GkcIdslK1eN7N6jIeHz" crossorigin="anonymous"></script>
</body>

</html>