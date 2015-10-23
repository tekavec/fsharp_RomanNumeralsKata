module ArabicToRomanConverter

let arabToRomanTuples = [(1000, "M"); (900, "CM"); (500, "D"); (400, "CD"); 
                         (100, "C"); (90, "XC"); (50, "L"); (40, "XL"); (10, "X"); 
                         (9, "IX"); (5, "V"); (4, "IV"); (1, "I")] 

type ArabicRoman(arabic, roman) =
    member x.Arabic = arabic
    member x.Roman = roman

type ArabicToRomans() = 
    member x.ArabicAndRoman = 
        arabToRomanTuples
        |> List.map (fun (a,r) -> new ArabicRoman(a, r)) 

    member x.FindRoman arabic =
        x.ArabicAndRoman 
        |> List.find (fun ar -> ar.Arabic <= arabic)

let a2r = new ArabicToRomans()

let rec ToRoman arabic =
    let arabToRoman = (a2r.FindRoman arabic)
    let remainder = arabic - arabToRoman.Arabic
    if remainder = 0
    then arabToRoman.Roman
    else ToRoman(arabToRoman.Arabic) + ToRoman(remainder)