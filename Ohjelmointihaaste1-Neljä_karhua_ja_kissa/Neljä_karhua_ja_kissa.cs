using System;

class Neljä_karhua_ja_kissa

{
    static void Main(string[] args)
    {
        int saalis;

        while (true)
        {
            Console.Write("Kuinka monta kalaa karhut ovat kalastaneet? ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out saalis))
            {
                break;
            }
            else
            {
                Console.Clear();
            }
        }

        int kalaaKarhulle = saalis / 4;
        int kalaaKissalle = saalis % 4;

        Console.WriteLine($"Karhut saavat {kalaaKarhulle} kalaa kappale ja kissa saa {kalaaKissalle} kalaa.");

        Console.WriteLine("Kolme kalamäärää, joissa kissa saa enemmän kalaa kuin karhut:");
        for (int i = 1; i <= 12; i++)
        {
            int karhu = i / 4;
            int kissa = i % 4;

            if (i > 4 && kissa > karhu)
            {
                Console.WriteLine(i);
            }
        }
    }
}
