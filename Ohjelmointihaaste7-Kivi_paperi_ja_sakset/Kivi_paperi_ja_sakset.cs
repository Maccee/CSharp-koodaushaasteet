using System;

class Kivi_paperi_ja_sakset
{
    static void Main(string[] args)
    {
        Console.Clear();
        bool pelaa = true;

        while (pelaa)
        {
            int pelaajaValinta = VainNumero("1 = Kivi, 2 = Paperi, 3 = Sakset : ");

            Random rnd = new Random();
            int tietokoneValinta = rnd.Next(1, 4);

            pelaa = TulostaTulos(pelaajaValinta, tietokoneValinta);
        }
    }

    static bool TulostaTulos(int pelaaja, int tietokone)
    {
        Console.WriteLine();
        Console.WriteLine($"Pelaaja valitsi: {MuunnaValinta(pelaaja)}");
        Console.WriteLine($"Tietokone valitsi: {MuunnaValinta(tietokone)}");

        if (pelaaja == tietokone)
        {
            Console.WriteLine("Tasapeli, pelataan uudelleen!");
            return true;
        }

        if ((pelaaja == 1 && tietokone == 3) || (pelaaja == 2 && tietokone == 1) || (pelaaja == 3 && tietokone == 2))
        {
            Console.WriteLine("Pelaaja voittaa!");
        }
        else
        {
            Console.WriteLine("Tietokone voittaa!");
        }

        return false;
    }

    static string MuunnaValinta(int valinta)
    {
        switch (valinta)
        {
            case 1:
                return "Kivi";
            case 2:
                return "Paperi";
            case 3:
                return "Sakset";
            default:
                return "Virheellinen valinta";
        }
    }

    static int VainNumero(string prompt)
    {
        
        ConsoleKeyInfo keyInfo;
        while (true)
        {
            Console.WriteLine();
            Console.Write(prompt);
            keyInfo = Console.ReadKey();
            if (int.TryParse(keyInfo.KeyChar.ToString(), out int value) && value >= 1 && value <= 3)
            {
                return value;
            }

        }

    }
}