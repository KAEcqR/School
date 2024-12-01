<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Poznaj Europę</title>
    <link rel="stylesheet" href="style.css">
</head>
<body>
    <header class="banner">
        <h1>BIURO PODRÓŻY</h1>
    </header>
    <main>
        <section class="left">
            <h2>Promocje</h2>
            <table>
                <tr>
                    <td>Warszawa</td>
                    <td>od 600 zł</td>
                </tr>
                <tr>
                    <td>Wenecja</td>
                    <td>od 1200 zł</td>
                </tr>
                <tr>
                    <td>Paryż</td>
                    <td>od 1200 zł</td>
                </tr>
            </table>
        </section>
        <section class="center">
            <h2>W tym roku jedziemy do...</h2>
            <?php
            require_once 'functions.php';
            $zdjecia = getZdjecia();
            echo "<div class='container'>";
            foreach ($zdjecia as $z) {
                echo "<img src='Media/{$z[0]}' title='{$z[1]}'>";
            }
            echo "</div>";
            ?>
        </section>
        <section class="right">
            <h2>Kontakt</h2>
            <a href="mailto:biuro@wycieczki.pl">napisz do nas</a>
            <p>telefon: 444555666</p>
        </section>
    </main>
    <div class="content">
        <h3>W poprzednich latach byliśmy...</h3>
        <form method="get">
            <label for="wybor" style="margin-bottom: 20px;">Jaki typ wycieczki</label>
            <select name="wybor" id="wybor">
                <option value="dostepne">Dostępne</option>
                <option value="niedostepne">Nie dostępne</option>
            </select>
            <button type="submit">Zatwierdź</button>
        </form>
        <?php
        if (isset($_GET['wybor'])) {
            if ($_GET['wybor'] == "dostepne") {
                $wycieczki = getWycieczkiDostepne();
                echo "<ol>";
                foreach ($wycieczki as $w) {
                    echo "<li> Dnia " . $w[0] . " pojedziemy do " . $w[1] . "</li>";
                }
                echo "</ol>";
            } elseif ($_GET['wybor'] == "niedostepne") {
                $wycieczki = getWycieczkiNieDostepne();
                echo "<ol>";
                foreach ($wycieczki as $w) {
                    echo "<li> Dnia " . $w[0] . " pojedziemy do " . $w[1] . "</li>";
                }
                echo "</ol>";
            }
        }
        ?>
    </div>
    <footer>
        <p>Stronę wykonał: 00000000000000000000</p>
    </footer>
</body>
</html>
