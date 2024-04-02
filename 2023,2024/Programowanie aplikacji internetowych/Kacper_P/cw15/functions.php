<?php
function Szyfr($text, $klucz) {     
    $alfabet = 'aąbcćdeęfghijklłmnńoóprsśtuwyzźż';
    $alfabet2 = 'AĄBCĆDEĘFGHIJKLŁMNŃOÓPRSŚTUWYZŹŻ';

    $zaszyfrowanyTekst = '';
    $dlugoscTekstu = mb_strlen($text, 'UTF-8');

    for ($i = 0; $i < $dlugoscTekstu; $i++) {
        $znak = mb_substr($text, $i, 1, 'UTF-8');

        $pozycja = mb_strpos($alfabet, $znak, 0, 'UTF-8');
        $pozycja2 = mb_strpos($alfabet2, $znak, 0, 'UTF-8');
        if ($pozycja !== false) {

            $nowaPozycja = ($pozycja + $klucz) % mb_strlen($alfabet);

            $zaszyfrowanyTekst .= mb_substr($alfabet, $nowaPozycja, 1, 'UTF-8');
        } elseif ($pozycja2 !== false) {
            $nowaPozycja = ($pozycja + $klucz) % mb_strlen($alfabet);

            $zaszyfrowanyTekst .= mb_strtoupper(mb_substr($alfabet, $nowaPozycja, 1, 'UTF-8'));
        } else {
            $zaszyfrowanyTekst .= $znak;
        }
    }

    return $zaszyfrowanyTekst;
}


if (isset($_POST['submit'])) {
    $text = $_POST['text'];
    $klucz = (int)$_POST['klucz'];

    $zaszyfrowanyTekst = Szyfr($text, $klucz);

    echo "Oryginalny tekst: $text<br>";
    echo "Zaszyfrowany tekst: $zaszyfrowanyTekst";
}
