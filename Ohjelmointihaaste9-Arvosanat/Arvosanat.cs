using System;
class Arvosanat
{
    static void Main(string[] args)
    {
        int numero = VainNumero("Anna numero välillä 0 - 5: ");
        string arvio = "";

        switch (numero)
        {
            case 0:
                arvio = "hylätty";
                break;
            case 1:
                arvio = "välttävä";
                break;
            case 2:
                arvio = "tyydyttävä";
                break;
            case 3:
                arvio = "hyvä";
                break;
            case 4:
                arvio = "kiitettävä";
                break;
            case 5:
                arvio = "erinomainen";
                break;
        }
        Console.WriteLine();
        Console.WriteLine($"Arvosanan {numero} sanallinen kuvaus on {arvio}.");

    }
    static int VainNumero(string prompt)
    {

        ConsoleKeyInfo keyInfo;
        while (true)
        {

            Console.Write(prompt);
            keyInfo = Console.ReadKey();
            if (int.TryParse(keyInfo.KeyChar.ToString(), out int value) && value >= 0 && value <= 5)
            {
                return value;
            }
            Console.WriteLine();
            Console.WriteLine("Virhe: Annettu arvosana ei ole välillä 0 - 5.");

        }

    }
}