module ArabicToRomanConverter

let rec ToRoman arabic =
    match arabic with
    | 1 -> "I"
    | x when x < 5 -> ToRoman(1) + ToRoman (arabic-1)
    | 5 -> "V"
    | x when x < 10 -> ToRoman(5) + ToRoman(arabic-5)
    | 10 -> "X"
    | x when x < 50 -> ToRoman(10) + ToRoman(arabic-10)
//    | 4 -> "IV"
//    | 5 -> "V"
//    | 6 -> "VI"
//    | 9 -> "IX"
//    | 10 -> "X"
//    | 14 -> "XIV"
//    | 17 -> "XVII"
//    | 46 -> "XLVI"