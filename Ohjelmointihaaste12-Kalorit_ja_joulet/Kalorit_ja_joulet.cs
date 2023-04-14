using System;
class Kalorit_ja_joulet
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Valikko:");
            Console.WriteLine("1. Kalorit jouleiksi");
            Console.WriteLine("2. Joulet kaloreiksi");
            Console.WriteLine("0. Poistu");
            Console.Write("Valitse muunnos: ");
            string? input = Console.ReadLine();

            if (input == "1")
            {
                ConvertCaloriesToJoules();
            }
            else if (input == "2")
            {
                ConvertJoulesToCalories();
            }
            else if (input == "0") { break; }
            else
            {
                Console.WriteLine("Virheellinen valinta, yritä uudelleen.");
                Console.ReadLine();
            }
        }
    }

    static void ConvertCaloriesToJoules()
    {
        Console.Write("Anna kalorimäärä: ");
        if (double.TryParse(Console.ReadLine(), out double calories))
        {
            double joules = calories * 4.184;
            double roundedJoules = Math.Round(joules, 3);
            Console.WriteLine($"{calories} cal on {roundedJoules} J.");
        }
        else
        {
            Console.WriteLine("Virheellinen syöte, yritä uudelleen.");
        }
        Console.ReadLine();
    }

    static void ConvertJoulesToCalories()
    {
        Console.Write("Anna joulemäärä: ");
        if (double.TryParse(Console.ReadLine(), out double joules))
        {
            double calories = joules * 0.239;
            double roundedCalories = Math.Round(calories, 3);
            Console.WriteLine($"{joules} J on {roundedCalories} cal.");
        }
        else
        {
            Console.WriteLine("Virheellinen syöte, yritä uudelleen.");
        }
        Console.ReadLine();
    }
}