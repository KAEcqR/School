<?php

function mb_text_exp(string $text,string $char) : string {
    $array = mb_str_split($text);
    $result = implode($char, $array);
    return $result;
}

echo mb_text_exp("Ała", "*");

function OnlyAlpha($text) : int {
    return strlen($text);
}

echo OnlyAlpha("Al a");