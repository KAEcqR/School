<!DOCTYPE html>
<html>
<head>
	<link rel="stylesheet" type="text/css" href="styl4.css">
	<meta charset="utf-8">
	<title>Restauracja Kulinaria.pl</title>
</head>
<body>
	<header>
		<h2>Restauracja Kulinaria.pl Zaprasza!</h2>
	</header>
	
	<nav>
		<p>Dania mięsne zamówisz już od  
			<?php
				$mysqli = new mysqli("localhost", "root", "", "baza_kr");
        if ($mysqli->connect_error) {
            die("Błąd połączenia z bazą danych: " . $mysqli->connect_error);
        }

        $query = "SELECT cena FROM dania WHERE typ=2 order by cena desc limit 1 ";
        $result = $mysqli->query($query);

        if ($result && $result->num_rows > 0) {
            while ($row = $result->fetch_assoc()) {
                $cena = htmlspecialchars($row['cena']);
				echo "$cena";
            }
        } else {
            echo "Brak wyników.";
        }
        $mysqli->close();
			
			?>
		</P>
		
		<img src="menu.jpg" alt="Pyszne spaghetti"><br>
		
	</nav>
	<main>
		<h3>Przekaski</h3>
		<?php
				$mysqli = new mysqli("localhost", "root", "", "baza_kr");
        if ($mysqli->connect_error) {
            die("Błąd połączenia z bazą danych: " . $mysqli->connect_error);
        }

        $query = "SELECT id, nazwa, cena FROM dania WHERE typ = 3";
        $result = $mysqli->query($query);

        if ($result && $result->num_rows > 0) {
            while ($row = $result->fetch_assoc()) {
				$id = htmlspecialchars($row['id']);
				$nazwa = htmlspecialchars($row['nazwa']);
                $cena = htmlspecialchars($row['cena']);
				echo "<center>$id $nazwa $cena</center><br>";
            }
        } else {
            echo "Brak wyników.";
        }
        $mysqli->close();
			
			?>
	</main>
	<aside>
	<h3>Napoje</h3>
		<?php
				$mysqli = new mysqli("localhost", "root", "", "baza_kr");
        if ($mysqli->connect_error) {
            die("Błąd połączenia z bazą danych: " . $mysqli->connect_error);
        }

        $query = "SELECT id, nazwa, cena FROM dania WHERE typ = 4";
        $result = $mysqli->query($query);

        if ($result && $result->num_rows > 0) {
            while ($row = $result->fetch_assoc()) {
				$id = htmlspecialchars($row['id']);
				$nazwa = htmlspecialchars($row['nazwa']);
                $cena = htmlspecialchars($row['cena']);
				echo "<p><center>$id $nazwa $cena</center></p><br>";
            }
        } else {
            echo "Brak wyników.";
        }
        $mysqli->close();
			
			?>
	</aside>
	
	<footer>
		Stronę internetową opracował: <i>PESEL</i>
	</footer>
</body>
</html>