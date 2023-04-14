using System;
class Numerot_merkkijonoksi
{
    static void Main(string[] args)
    {
        string alkuperäinenTeksti = "Herra Huun osoite on tattisuonkatu 1099 A 1019.";
        string muutettuTeksti = NumerotTekstiksi.Muunna(alkuperäinenTeksti);
        Console.WriteLine("Alkuperäinen teksti: " + alkuperäinenTeksti);
        Console.WriteLine("Muutettu teksti: " + muutettuTeksti);
    }
}