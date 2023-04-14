using System;
using System.Text.RegularExpressions;
public class NumerotTekstiksi
{
    private static string[] yksiköt = { "", "yksi", "kaksi", "kolme", "neljä", "viisi", "kuusi", "seitsemän", "kahdeksan", "yhdeksän" };
    private static string[] kymmenet = { "", "kymmenen", "kaksikymmentä", "kolmekymmentä", "neljäkymmentä", "viisikymmentä", "kuusikymmentä", "seitsemänkymmentä", "kahdeksankymmentä", "yhdeksänkymmentä" };
    private static string[] sadat = { "", "sata", "kaksisataa", "kolmesataa", "neljäsataa", "viisisataa", "kuusisataa", "seitsemänsataa", "kahdeksansataa", "yhdeksänsataa" };
    public static string Muunna(string teksti)
    {
        string pattern = @"\d+";
        Regex regex = new Regex(pattern);

        return regex.Replace(teksti, delegate (Match match)
        {
            int numero = int.Parse(match.Value);
            return NumeroSanaksi(numero);
        });
    }
    public static string NumeroSanaksi(int numero)
{
    if (numero == 0)
    {
        return "nolla"; // numero 0 
    }
    else if (numero < 10)
    {
        return yksiköt[numero]; // numerot 1 - 9
    }
    else if (numero < 20 && numero > 10)
    {
        return NumeroSanaksi(numero % 10) + "toista"; // numerot 11 - 19
    }
    else if (numero < 100)
    {
        int kymmenen = numero / 10;
        int yksikkö = numero % 10;
        return kymmenet[kymmenen] + yksiköt[yksikkö]; // jos numero 10 => kymmenen
    }
    else if (numero < 1000)
    {
        int sata = numero / 100;
        int kymmenetJaYksiköt = numero % 100;
        Console.WriteLine(kymmenetJaYksiköt);

        if (kymmenetJaYksiköt == 0)
        {
            return sadat[sata]; // jos numero tasan satoja
        }
        else if (kymmenetJaYksiköt < 10)
        {
            return sadat[sata] + yksiköt[kymmenetJaYksiköt]; // jos numero esim 402 tai 305
        }
        else if (kymmenetJaYksiköt < 20)
        {
            return sadat[sata] + (NumeroSanaksi(kymmenetJaYksiköt % 10)) + "toista"; // jos numero 213, 12, 815
        }
        else
        {
            int kymmenen = kymmenetJaYksiköt / 10;
            int yksikkö = kymmenetJaYksiköt % 10;
            return sadat[sata] + kymmenet[kymmenen] + yksiköt[yksikkö];
        }
    }
    else
    {
        return "tuhat" + NumeroSanaksi(numero % 1000);
    }
}
}