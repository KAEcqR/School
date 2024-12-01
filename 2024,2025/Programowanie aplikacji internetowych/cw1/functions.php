<?php
$linie = file('dane.txt');
$licznik = 0;

$tabela = '<table class="table table-hover">
  <thead>
    <tr>
      <th scope="col">Rok</th>
      <th scope="col">Tytuł</th>
      <th scope="col">Autor</th>
      <th scope="col">Cena</th>
    </tr>
  </thead>
  <tbody>';

$tabela .= '<tr>';

foreach ($linie as $index => $linia) {
    
    $tabela .= "<td>$linia</td>";

    if (($index + 1) % 5 == 0) {
        $tabela .= '</tr><tr>'; 
    }
}

$tabela .= '</tbody></table>';

echo $tabela;
?>