using System;

class Ritariryhma_liikkeelle
{


    static void Main(string[] args)
    {
        Console.Title = "Ritariryhmä Liikkeelle";

        int rivi = VainNumero("Anna kohde rivi (1-8): ");
        int sarake = VainNumero("Anna kohde sarake (1-8): ");
        

        int[] riviMuutos = { -1, 1, 0, 0 };
        int[] sarakeMuutos = { 0, 0, -1, 1 };

        Console.WriteLine("Lähetetään ritarit.");
        Console.ForegroundColor = ConsoleColor.Red;

        for (int i = 0; i < 4; i++)
        {
            int uusiRivi = rivi + riviMuutos[i];
            int uusiSarake = sarake + sarakeMuutos[i];

            if (uusiRivi >= 1 && uusiRivi <= 8 && uusiSarake >= 1 && uusiSarake <= 8)
            {
                Console.WriteLine($"Ritari {i + 1} kohteeseen ({uusiRivi}, {uusiSarake})");
                //Console.Beep();
            }
        }

        Console.ResetColor();
        //Console.ReadKey();
    }

    static int VainNumero(string prompt)
    {
        while (true)
        {
            Console.Write(prompt);
            string input = Console.ReadLine();
            if (int.TryParse(input, out int value) && value >= 1 && value <= 8)
            {
                return value;
            }
            
        }
    }
}