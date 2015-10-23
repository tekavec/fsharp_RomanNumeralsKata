module RomanNumeralsTests

open NUnit.Framework
open ArabicToRomanConverter

    [<TestCase(1, "I")>]
    [<TestCase(2, "II")>]
    [<TestCase(3, "III")>]
    [<TestCase(4, "IV")>]
    [<TestCase(5, "V")>]
    [<TestCase(6, "VI")>]
    [<TestCase(8, "VIII")>]
    [<TestCase(9, "IX")>]
    [<TestCase(10, "X")>]
    [<TestCase(20, "XX")>]
    [<TestCase(14, "XIV")>]
    [<TestCase(17, "XVII")>]
    [<TestCase(44, "XLIV")>]
    [<TestCase(50, "L")>]
    [<TestCase(90, "XC")>]
    [<TestCase(400, "CD")>]
    [<TestCase(900, "CM")>]
    [<TestCase(500, "D")>]
    [<TestCase(1017, "MXVII")>]
    [<TestCase(2499, "MMCDXCIX")>]
    [<TestCase(3949, "MMMCMXLIX")>]
    let Test arabic expectedRoman =
        let roman = arabic |> ToRoman
        Assert.AreEqual(expectedRoman, roman)