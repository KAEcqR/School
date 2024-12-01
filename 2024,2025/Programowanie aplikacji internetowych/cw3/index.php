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
        <h1>Lista Produktow</h1>
        <table class="table table-striped">
            <tr>
                <th>Lp</th>
                <th>Nazwa</th>
                <th>Opis</th>
                <th>Kategoria</th>
                <th>Cena</th>
                <th>Akcja</th>
            </tr>
            <?php
            require_once 'functions.php';
            $products = getProducts();
            $lp = 0;
            foreach ($products as $p) {
                $lp++;
                echo "<tr>";
                echo "<td>{$lp}</td>";
                echo "<td>{$p[1]}</td>";
                echo "<td>{$p[2]}</td>";
                echo "<td>" . getCategoryFromId($p[3]). "</td>";
                echo "<td>{$p[4]}</td>";
                echo "<td><a class='btn btn-outline-secondary' href='removeFromDb.php?id={$p[0]}'>Usuń</a></td>";
                echo "</tr>";
            }
            ?>
        </table>
        <div>
            <a class="btn btn-outline-secondary" href="addForm.php">Dodaj produkt</a>
            <a class="btn btn-outline-secondary" href="kategorie.php">Kategorie</a>
        </div>
    </main>
</body>
</main>

<script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.3/dist/js/bootstrap.bundle.min.js" integrity="sha384-YvpcrYf0tY3lHB60NNkmXc5s9fDVZLESaAA55NDzOxhy9GkcIdslK1eN7N6jIeHz" crossorigin="anonymous"></script>
</body>

</html>