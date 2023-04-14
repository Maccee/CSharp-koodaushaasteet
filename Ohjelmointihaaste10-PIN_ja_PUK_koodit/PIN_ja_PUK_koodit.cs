using System;

class PIN_ja_PUK_koodit
{
    static void Main(string[] args)
    {
        int pinAttempts = 0;
        int pukAttempts = 0;
        bool pinUnlocked = false;
        string correctPin = "1234";
        string correctPuk = "12345678";

        while (pinAttempts < 3 && !pinUnlocked)
        {
            Console.Write("Anna nelinumeroinen PIN-koodi: ");
            string? inputPin = Console.ReadLine();

            if (inputPin == correctPin)
            {
                pinUnlocked = true;
                Console.WriteLine("PIN-koodi on oikein!");
            }
            else
            {
                pinAttempts++;
                Console.WriteLine("PIN-koodi on väärin!");
            }
        }

        if (!pinUnlocked)
        {
            while (pukAttempts < 3 && !pinUnlocked)
            {
                Console.Write("Anna kahdeksannumeroinen PUK-koodi: ");
                string? inputPuk = Console.ReadLine();

                if (inputPuk == correctPuk)
                {
                    pinUnlocked = true;
                    Console.WriteLine("PUK-koodi on oikein, laite on avattu!");
                }
                else
                {
                    pukAttempts++;
                    Console.WriteLine("PUK-koodi on väärin!");
                }
            }

            if (!pinUnlocked)
            {
                Console.WriteLine("Laite on pysyvästi lukittu.");
            }
        }
    }
    
}