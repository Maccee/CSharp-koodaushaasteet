namespace Arvuutuskone
{
    using System;
    class Arvuutuskone
    {
        static void Main(string[] args)
        {
            int guess = 0;
            int number = 0;

            while (true)
            {
                try
                {
                    Console.Clear();
                    Console.WriteLine("User 1, enter a number between 0 and 100: ");
                    number = Convert.ToInt32(Console.ReadLine());
                    if (number >= 1 && number <= 100)
                    {
                        break;
                    }
                }
                catch (FormatException)
                {

                }
            }

            Console.Clear();
            Console.WriteLine("User 2, guess the number.");

            while (true)
            {
                try
                {
                    Console.Write("What is your next guess? ");
                    guess = Convert.ToInt32(Console.ReadLine());

                    if (guess >= 1 && guess <= 100)
                    {
                        if (guess < number)
                        {
                            Console.WriteLine(guess + " is too low.");
                        }
                        else if (guess > number)
                        {
                            Console.WriteLine(guess + " is too high.");
                        }
                        else
                        {
                            Console.WriteLine("You guessed the number!");
                            break;
                        }
                    }
                }
                catch (FormatException)
                {

                }
            }
        }
    }
}