<?php
// Połączenie z bazą danych
$host = 'localhost';
$user = 'root';
$password = '';
$dbname = 'hotele_kr';

$conn = new mysqli($host, $user, $password, $dbname);
if ($conn->connect_error) {
    die("Błąd połączenia: " . $conn->connect_error);
}
?>
<!DOCTYPE html>
<html lang="pl">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Wakacje.pl</title>
    <link rel="stylesheet" href="style.css">
</head>
<body>
    <div class="header">
        <img src="obraz.png" alt="Wakacje.pl logo" id="logo">
        <nav>
            <a href="#">Strona główna</a>
            <a href="#">Partnerzy</a>
            <a href="#">Biuro</a>
            <a href="#">Kontakt</a>
        </nav>
    </div>

    <div class="content">
        <!-- Sekcja z listą hoteli -->
        <div class="hotels-list">
            <h2>Nasze hotele to:</h2>
            <p>
                <?php
                $result3 = $conn->query("SELECT id, nazwa FROM hotele");
                while ($row = $result3->fetch_assoc()) {
                    echo $row['id'] . '. ' . $row['nazwa'] . ', ';
                }
                ?>
            </p>
        </div>

        <!-- Formularz do wyświetlenia danych hotelu -->
        <form method="POST">
            <label for="id_hotel">Podaj numer hotelu:</label>
            <input type="number" name="id_hotel" id="id_hotel" required>
            <button type="submit" name="show_details">Pokaż dane</button>
        </form>

        <!-- Wyświetlenie szczegółów wybranego hotelu -->
        <?php
        if (isset($_POST['show_details']) && isset($_POST['id_hotel'])) {
            // Pobieramy ID hotelu z formularza
            $idHotel = (int)$_POST['id_hotel'];

            // Zapytanie SQL po ID hotelu
            $result1 = $conn->query("SELECT * FROM hotele WHERE id = $idHotel");

            // Sprawdzamy, czy hotel istnieje
            if ($hotelDetails = $result1->fetch_assoc()) {
                ?>
                <div class="hotel-details">
                    <div class="hotel-map">
                        <img src="<?= $hotelDetails['mapa'] ?>" alt="Mapa hotelu" id="mapahotel">
                    </div>
                    <div class="hotel-info">
                        <h3>Hotel: <?= $hotelDetails['nazwa'] ?></h3>
                        <p>Cena hotelu: <?= $hotelDetails['cena'] ?> PLN/os</p>
                        <p>Samolot: <?= $hotelDetails['samolot'] ?> PLN/os</p>
                        <p>Wyżywienie: <?= $hotelDetails['wyzywienie'] ?> PLN/os</p>
                        <p>Ubezpieczenie: <?= $hotelDetails['ubezpieczenie'] ?> PLN/os</p>
                        <p>Transport: <?= $hotelDetails['transport'] ?> PLN/os</p>
                        <p><strong>RAZEM: <?= $hotelDetails['cena'] + $hotelDetails['samolot'] + $hotelDetails['wyzywienie'] + $hotelDetails['ubezpieczenie'] + $hotelDetails['transport'] ?> PLN/os</strong></p>
                    </div>
                </div>
                <?php
            } else {
                echo "<p>Nie znaleziono hotelu o podanym ID.</p>";
            }
        }
        ?>

        <!-- Sekcja promocji -->
        <div class="promo">
            <h2>PROMOCJA</h2>
            <p>
                Minimalna cena za hotel to:
                <?php
                $result2 = $conn->query("SELECT MIN(cena) AS min_cena FROM hotele");
                $minCena = $result2->fetch_assoc()['min_cena'];
                echo $minCena . " PLN";
                ?>
            </p>
        </div>
    </div>
</body>
</html>
