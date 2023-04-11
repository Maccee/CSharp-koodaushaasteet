using System;
class Vartiotorni
{
    static void Main(string[] args)
    {
        int x = VainNumero("Anna x-arvo: ");
        int y = VainNumero("Anna y-arvo: ");


        string suunta = "!";

        if (y > 0)
        {
            suunta += "north";
        }
        else if (y < 0)
        {
            suunta += "south";
        }

        if (x > 0)
        {
            suunta += suunta.Length > 0 ? " east." : "east.";
        }
        else if (x < 0)
        {
            suunta += suunta.Length > 0 ? " west." : "west.";
        }

        Console.WriteLine($"The enemy is to the {suunta}");
    }
    static int VainNumero(string prompt)
    {
        while (true)
        {
            Console.Write(prompt);
            string input = Console.ReadLine();
            if (int.TryParse(input, out int value))
            {
                return value;
            }

        }
    }
}