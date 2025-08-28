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
            <form action="preferencje.php" method="post">
       
                <label>Podajilosc</label><input type="text" name="ilosc">
             
                <button type="submit">Pokaż dane</button>
                </form>

                <?php
                $conn = new mysqli("localhost", "root", null, "przedszkole");
                if(isset($_POST['ilosc'])){
                    $ilosc = $_POST['ilosc'];
                   
                
                $sql = "select dzieci.Imie, dzieci.Nazwisko from dzieci INNER JOIN preferencje on dzieci.Pesel = preferencje.Pesel where preferencje.Numer_preferencji = {$ilosc}";
                
                $result = $conn->query($sql);
                if($result->num_rows > 0){
                    while($row=$result->fetch_assoc()){
                        echo " {$row['Imie']} {$row['Nazwisko']} <br>";
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