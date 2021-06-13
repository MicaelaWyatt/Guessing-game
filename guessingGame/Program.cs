using System;

namespace guessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            guessingGame();
            guessingGame();
            guessingGame();
            guessingGame();
        }


        static void guessingGame()
        {
            int secretNumber = 42;
            Console.WriteLine("??Guess the secret number??");
            string usersGuess = Console.ReadLine();
            int Guess = Convert.ToInt32(usersGuess);
            // Console.WriteLine(Convert.ToInt32(usersGuess));
            if (Guess == secretNumber)
            {
                Console.WriteLine("Dang! Did you cheat?");
            }
            else
            {
                Console.WriteLine("That was so off. Do you wanna try again?");
            }
        }
    }
}
