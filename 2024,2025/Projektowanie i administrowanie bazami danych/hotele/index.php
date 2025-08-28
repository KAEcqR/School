<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="stylesheet" href="styl.css">
    <title>Hotele</title>

</head>
<body>

<header>
    <img src="baner.jpg">
</header>
<main>
    
    <section id="prawy">
    <?php

$conn = mysqli_connect("localhost", "root", "", "klima");
if (!$conn) {
    die("Błąd połączenia z bazą danych: " . mysqli_connect_error());
}


$action = isset($_GET['action']) ? $_GET['action'] : 'list';


if ($action === 'list') {
    echo "<h3>Lista hoteli</h3>";
    $query = "SELECT id, nazwa FROM hotele";
    $result = mysqli_query($conn, $query);

    if (mysqli_num_rows($result) > 0) {
        echo "<ul>";
        while ($row = mysqli_fetch_assoc($result)) {
            echo "<li>ID: " . $row['id'] . " - Nazwa: " . htmlspecialchars($row['nazwa']) . "</li>";
        }
        echo "</ul>";
    } else {
        echo "Brak hoteli w bazie danych.";
    }

    echo '<form action="?action=details" method="post">
            <label for="hotelnr">Podaj numer hotelu:</label>
            <input type="number" id="hotelnr" name="hotelnr" required>
            <button type="submit">Pokaż dane hotelu</button>
          </form>';

    echo '<a href="?action=promotion">Zobacz promocję</a>';
}


    $nrhotelu = intval($_POST['hotelnr']);
    $query = "SELECT id, nazwa, cena, samolot, wyżywienie, ubezpieczenie, transport, 
              (cena + samolot + wyżywienie + ubezpieczenie + transport) AS total, mapa 
              FROM hotele WHERE id = ?";
    $stmt = $conn->prepare($query);
    if ($nrhotelu) {
        $stmt->bind_param("i", $nrhotelu);    
    } else {
        $stmt->bind_param("i", 1);
    }
    $stmt->execute();
    $result = $stmt->get_result();

    if ($result->num_rows > 0) {
        while ($row = $result->fetch_assoc()) {
            echo "<div class='border'>";
            echo "<h3>Dane hotelu</h3>";
            echo "<ul>
                    <li><strong>Nazwa:</strong> " . htmlspecialchars($row['nazwa']) . "</li>
                    <li><strong>Cena:</strong> " . htmlspecialchars($row['cena']) . " zł</li>
                    <li><strong>Samolot:</strong> " . htmlspecialchars($row['samolot']) . " zł</li>
                    <li><strong>Wyżywienie:</strong> " . htmlspecialchars($row['wyżywienie']) . " zł</li>
                    <li><strong>Ubezpieczenie:</strong> " . htmlspecialchars($row['ubezpieczenie']) . " zł</li>
                    <li><strong>Transport:</strong> " . htmlspecialchars($row['transport']) . " zł</li>
                    <li><strong>Łączny koszt:</strong> " . htmlspecialchars($row['total']) . " zł</li>
                  </ul>";
            echo "<img src='" . htmlspecialchars($row['mapa']) . "' alt='Mapa hotelu'>";
            echo "</div>";
        }
    } else {
        echo "Nie znaleziono hotelu o podanym ID.";
    }
    $stmt->close();
    echo '<a href="?action=list">Powrót do listy hoteli</a>';


if ($action === 'promotion') {
    $query1 = "SELECT MIN(cena) AS min_cena FROM hotele";
    $result1 = mysqli_query($conn, $query1);

    if ($row = mysqli_fetch_assoc($result1)) {
        echo "<h3>Promocja</h3>";
        echo "<p>Najniższa cena hotelu: " . htmlspecialchars($row['min_cena']) . " zł</p>";
    } else {
        echo "Nie udało się znaleźć minimalnej ceny.";
    }

    echo '<a href="?action=list">Powrót do listy hoteli</a>';
}

mysqli_close($conn);
?>
    </section>
</main>
</body>
</html>
