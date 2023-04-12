using System;
class Lihapiirakka_ongelma
{
    static void Main(string[] args)
        {
            
            decimal lompakossaRahaa = VainNumero("Kuinka paljon rahaa sinulla on lompakossa? ");
            decimal lihapiirakanHinta = VainNumero("Paljonko lihapiirakka maksaa? ");

            if (lompakossaRahaa >= lihapiirakanHinta)
            {
                decimal rahaaJaljella = lompakossaRahaa - lihapiirakanHinta;
                Console.WriteLine($"Sinulla on varaa ostaa lihapiirakka! Lompakkoon jää vielä {rahaaJaljella.ToString("F2")} euroa.");
            }
            else
            {
                Console.WriteLine("Et voi ostaa lihapiirakkaa. Sinun täytyy paastota.");
            }
        }
        static decimal VainNumero(string prompt)
    {
        while (true)
        {
            Console.Write(prompt);
            string? input = Console.ReadLine();
            if (decimal.TryParse(input, out decimal value) && value >= 0)
            {
                return value;
            }
            
        }

    }
}