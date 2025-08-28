<html>
<head>
  <meta charset="UTF-8">
  <meta name="viewport" content="width=device-width, initial-scale=1.0">
  <meta http-equiv="X-UA-Compatible" content="ie=edge">
  <title>Grzybobranie</title>
  <link rel="stylesheet" href="styl5.css">
</head>
<body>
  <section id="miniatura">
    <a href="borowik.jpg"><img src="borowik-miniatura.jpg" alt="Grzybobranie"></a>
  </section>

  <section id="tytulowy">
    <h1>Idziemy na grzyby!</h1>
  </section>

  <section id="lewy">
    <!-- skrypt 1 -->
    <?php
    include_once("functions.php");

    $zdjecia = getGrzyby();

    foreach ($zdjecia as $z) {
      echo "<img src='{$z[0]}' title='{$z[1]}'>";
    }
    ?>
  </section>

  <section id="prawy">
    <h2>Grzyby jadalne</h2>
    <!-- skrypt 2 -->
    <?php
   
    ?>
    <h2>Polecamy do sosów</h2>
    <!-- skrypt 3 -->
    <?php
  
    ?>
  </section>

  <section id="stopka">
    <p>Autor: 0000000000</p>
  </section>
</body>
</html>
