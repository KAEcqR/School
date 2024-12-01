<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Galeria</title>
    <link rel="stylesheet" href="style.css">
</head>
<body>
    <header>
        <h1>Zdjęcia</h1>
    </header>
    <main>
        <aside>
            <h2>Tematy zdjęć</h2>
            <ol>
                <li>Zwierzęta</li>
                <li>Krajobrazy</li>
                <li>Miasta</li>
                <li>Przyroda</li>
                <li>Samochody</li>
            </ol>
        </aside>
        <section>
        <?php
        function getConnection(): ?mysqli
        {
            $conn = new mysqli('localhost', 'root',
            null, '3tip_arkusz1');//wywołanie konstruktora klasy mysqli
            if($conn->connect_errno!=0) return null;
            return $conn;
        }

        function getPhotos() {
            $conn = getConnection();//pobranie połączenia
            if($conn==null) return [];//jeśli nie udało się połączyć z bazą danych to zwracamy pustą tablicę
            $sql = "SELECT plik,tytul,polubienia,autorzy.imie,autorzy.nazwisko FROM `zdjecia` INNER join `autorzy` on autorzy_id = autorzy.id ORDER BY autorzy.nazwisko ASC;";
            $result = $conn->query($sql);//wykonanie zapytania
            $photos = [];
            while($row = $result->fetch_row()){//pobieranie wiersza z wyniku zapytania
                $photos[] = $row;//dodanie wiersza do tablicy groups
            }
            $conn->close();//zamknięcie połączenia
            for($i = 0; $i < count($photos); $i++){
                showPhoto($photos[$i]);//wyświetlenie zdjęcia
            }
            return $photos;
        }

        function showPhoto(array $photo){
            echo "<div class='photo'>";
            echo "<img src='zdjecia/{$photo[0]}' alt='zdjęcie'>";
            echo "<h3>{$photo[1]}</h3>";
            echo "<p>Autor: {$photo[3]} {$photo[4]} </br> Polubienia: {$photo[2]}</p>";
            echo "<a href=''>Pobierz zdjęcie</a>";
            echo "<a href='likephoto.php?name={$photo[1]}' class='a2'>Polub zdjęcie</a>";
            echo "</div>";
        }
        
        getPhotos();
    ?>


        </section>
        <aside>
            <h2>Najbardziej lubiane</h2>
            <strong>Zobacz wszystkie nasze zdjęcia</strong>
        </aside>
    </main>
    <footer>
        <h5>stronę wykonał : 000000000000000000</h5>
    </footer>
    
</body>
</html>