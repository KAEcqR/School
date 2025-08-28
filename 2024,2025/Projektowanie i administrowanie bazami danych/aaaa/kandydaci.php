<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>
<style>
    table{
      margin-left: auto;
      margin-right: auto;
        height: 700px;
    }

    tr,td{
        border: 2px black solid ;
        vertical-align: top;
      
    }
</style>
<body>
    <table style="width:80%;">
        <tr> <td colspan="2" style="height: 150px;">
        <img src="baner.jpg" height="150px" width="100%">
        </td></tr>
        <tr> 
            <td style="width:15%; text-align: center;   padding: 20px;">
                <a href="kandydaci.php">kandydaci</a> <br>
                <a href="preferencje.php">preferencje</a> <br>
                <a href="top.php">top</a> <br>
            </td>
            <td style="width:85%;   padding: 20px;">
            <form action="kandydaci.php" method="post">
            <label>Podaj płeć dziecka (dziewczynka/chlopiec):</label><input type="text" name="plec">
                <label>Podaj wiek dziecka (3-6):</label><input type="text" name="wiek">
                <label>Podaj numer przedszkola (1-47):</label><input type="text" name="numer">
                <button type="submit">Pokaż dane</button>
                </form>

                <?php
                $conn = new mysqli("localhost", "root", null, "przedszkole");
                if(isset($_POST['plec'])){
                    $plec = $_POST['plec'];
                    $wiek = $_POST['wiek'];
                    $numer = $_POST['numer'];
                
                $sql = "SELECT dzieci.Imie, dzieci.Nazwisko, dzieci.plec, dzieci.wiek, przedszkola.Nazwa_przedszkola FROM dzieci INNER JOIN preferencje ON dzieci.Pesel = preferencje.Pesel INNER JOIN przedszkola on preferencje.Id_przedszkola = przedszkola.Id_przedszkola WHERE dzieci.plec = '{$plec}' and dzieci.wiek = '{$wiek}' and przedszkola.Id_przedszkola = '{$numer}' group by dzieci.Nazwisko";
                
                $result = $conn->query($sql);
                if($result->num_rows > 0){
                    while($row=$result->fetch_assoc()){
                        echo "Wiek {$wiek}\nPlec {$plec}\n {$row['Imie']} {$row['Nazwisko']} {$row['Nazwa_przedszkola']} <br>";
                    }
                }
                else{

                }
            }
                ?>
            </td>
        </tr>
       
    </table>
</body>
</html>