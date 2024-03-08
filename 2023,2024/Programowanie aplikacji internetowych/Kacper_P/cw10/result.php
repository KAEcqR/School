<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>
<body>
    <?php
        if (isset($_POST['a'])) {
            $a = $_POST['a'];
            $b = $_POST['b'];
            $c = $_POST['wyb'];
            $wynik = 0;
        
            if (!empty($a)) {
                switch ($c) {   
                    case 'dod':
                        $wynik = $a + $b;
                        break;
                    case 'odj':
                        $wynik = $a - $b;
                        break;
                    case 'mno':
                        $wynik = $a * $b;
                        break;
                    case 'dzi':
                        if ($b == 0) {
                            echo '<p>Błąd: Nie można dzielić przez zero.</p>';
                        } else {
                            $wynik = $a / $b;
                        }
                        break;
                    default:
                        echo '<p>Błąd: Nieznane działanie.</p>';
                }
        
                echo <<< Text
                    <div class="info">
                    <p>Wynik twojego działania to: {$wynik}</p>
                    </div>
Text;
            }
        } else {
            echo '<p>Brak danych</p>';
        }
    ?>
</body>
</html>