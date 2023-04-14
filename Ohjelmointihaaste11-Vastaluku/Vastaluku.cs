using System;
class Vastaluku
{
    static void Main(string[] args)
    {
        int[] numerot = new int[10];

        Random rand = new Random();
        for (int i = 0; i < numerot.Length; i++)
        {
            numerot[i] = rand.Next(1, 101);
        }
        
        Console.WriteLine("Alkuperäinen taulukko:");
        foreach (int numero in numerot)
        {
            Console.Write(numero + " ");
        }
        Console.WriteLine();
        
        MuutaVastaluvuiksi(numerot);
        
        Console.WriteLine("Taulukko vastaluvuilla:");
        TulostaVastaluvut(numerot);
    }

    static void MuutaVastaluvuiksi(int[] taulukko)
    {
        for (int i = 0; i < taulukko.Length; i++)
        {
            taulukko[i] = -taulukko[i];
        }
    }

    static void TulostaVastaluvut(int[] taulukko)
    {
        foreach (int numero in taulukko)
        {
            Console.Write(numero + " ");
        }
        Console.WriteLine();
    }
}