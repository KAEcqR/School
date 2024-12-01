<?php 

class Game {
    private string $tytul;
    private int $rok;
    private string $typ;

    public function __construct (string $tytul, int $rok, string $typ){
        $this->tytul = $tytul;
        $this->rok = $rok;
        $this->typ = $typ;
    }

    public function _toString() {
        return "Tytuł: ". $this->tytul. ", Rok: ". $this->rok. ", Typ: ". $this->typ;
    }

}