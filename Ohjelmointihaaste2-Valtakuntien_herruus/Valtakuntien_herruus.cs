using System;

class Valtakuntien_herruus
{


    static void Main(string[] args)
    {
        int maatilat = VainNumero("Syötä pelaajan maatilojen lukumäärä: ");
        int herttuakunnat = VainNumero("Syötä pelaajan herttuakuntien lukumäärä: ");
        int maakunnat = VainNumero("Syötä pelaajan maakuntien lukumäärä: ");

        int pisteet = maatilat * 1 + herttuakunnat * 3 + maakunnat * 6;
        Console.WriteLine("Pelaajan pisteet yhteensä: " + pisteet);
    }
    static int VainNumero(string prompt)
    {
        while (true)
        {
            Console.Write(prompt);
            string? input = Console.ReadLine();
            if (int.TryParse(input, out int value) && value >= 0)
            {
                return value;
            }
            
        }
    }
}