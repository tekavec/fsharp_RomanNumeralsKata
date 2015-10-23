﻿module ArabicToRomanConverter

let ArabicAndRoman = [(10, "X"); (9, "IX"); (5, "V"); (4, "IV"); (1, "I")]

let FindRoman arabic =
    ArabicAndRoman 
    |> List.find (fun (arab, roman) -> arab <= arabic)


let rec ToRoman arabic =
    let arabToRoman = (FindRoman arabic)
    let arab = fst arabToRoman
    let roman = snd arabToRoman
    let remainder = arabic - arab
    if remainder = 0
    then roman
    else ToRoman(arab) + ToRoman(remainder)

//    | 4 -> "IV"
//    | 5 -> "V"
//    | 6 -> "VI"
//    | 9 -> "IX"
//    | 10 -> "X"
//    | 14 -> "XIV"
//    | 17 -> "XVII"
//    | 46 -> "XLVI"