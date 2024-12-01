<?php 

class Person {
    private string $name;
    private int $age;
    private string $gender;
    private array $interests;

    public function __construct (string $name, int $age, string $gender, array $interests){
        $this -> name = $name;
        $this -> age = $age;
        $this -> gender = $gender;
        $this -> interests = $interests;
    }

    public function _toString():string {
        $result = "<p>Imie: {$this->name}, wiek: {$this->age},"
            ." płeć: {$this->gender}";
        $result .= "<p>Zainteresowania: </p>";
        if (count($this -> interests) > 0) {
            $result .= "<ul>";
            foreach ($this -> interests as $interest) {
                $result.= "<li>{$interest}</li>";
            }
            $result .= "</ul>";
        } else {
            $result.= "<p>Brak zainteresowań.</p>";
        }
        return $result;
    }

}