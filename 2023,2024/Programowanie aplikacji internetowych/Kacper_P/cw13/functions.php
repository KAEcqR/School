<?php

function GetDivision():array {
    return ["1A", "1B", "1C", "1TI", "1TIP", "1THE"];
}

function DivisionToSelect(array $list):string {
    $html = "<select name='divisions' class='col-6'>";
    foreach($list as $item){
        $html .= "\t<option value='{$item}'> {$item}</option>\n";
    }
    $html .= "</select>";
    return $html;
}

function GetHobby():array {
    return ["Muzyka", "Taniec", "Gry", "Sport", "Pilka", "Ksiazki"];
}

function HobbyToCheckBox(array $items){
    $html = "<div class='col-6'>";
    foreach($items as $i){
        $html .= "\t<input type='checkbox' name='hobbies[]' value='{$i}'><label>{$i}</label>";
    }
    $html .= "</div>";
    return $html;
}

function Wyswietl(): string {
    $html = "";

    if (isset($_POST['submit'])) {
        $firstname = trim($_POST['firstname']);
        $lastname = trim($_POST['lastname']);
        $divisions = trim($_POST['divisions']);
        $gender = isset($_POST['gender']) && $_POST['gender'] === 'K' ? "Kobieta" : "Mężczyzna";

        $html .= "<div class='card col-6' style='width: 18rem; margin-left: 310px; margin-top: 20px;'>
                    <div class='card-header'>$firstname $lastname</div>
                    <ul class='list-group list-group-flush'>
                    <li class='list-group-item'>$gender</li>
                    <li class='list-group-item'>$divisions</li>";
    }

    if (isset($_POST['hobbies'])) {
        $hobbies = $_POST['hobbies'];

        foreach ($hobbies as $h) {
            $html .= "<li class='list-group-item'>$h</li>";
        }

        $html .= '</ul></div>';
    }else{
        $html .= "<li class='list-group-item'>Brak Zainteresowań</li>";
        
        $html .= '</ul></div>';
    }

    return $html;
}
