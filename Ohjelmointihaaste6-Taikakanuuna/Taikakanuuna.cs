using System;
using System.Threading;
class Taikakanuuna
{
    static void Main(string[] args)
    {
        string ammus = "";
        while (true)
        {
            Console.Clear();
            for (int i = 1; i <= 100; i++)
            {
                Console.ResetColor();
                ammus = "Normal";

                if (i % 3 == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    ammus = "Fire";
                }

                if (i % 5 == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    ammus = "Electric";
                }

                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    ammus = "Electric and Fire";
                }

                Console.WriteLine($"{i}: {ammus}");
                Thread.Sleep(20);

            }
            Console.ResetColor();
            ConsoleKeyInfo keyInfo;
            Console.Write("Ammukset loppu! Ladataanko ase? (y/n): ");
            while (true)
            {
                keyInfo = Console.ReadKey();
                if (keyInfo.KeyChar == 'n' || keyInfo.KeyChar == 'y')
                {
                    break;
                }
            }

            if (keyInfo.KeyChar == 'n')
            {
                break;
            }
        }


    }
}