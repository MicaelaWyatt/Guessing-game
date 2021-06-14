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
            int listOfGuesses = Convert.ToInt32(usersGuess);
            string[] guesses = { usersGuess };
            foreach (string guess in guesses)
            {
                int numOfGuesses = guesses.Length;
                Console.WriteLine($"Your guess({numOfGuesses})>");
            };
            // Console.WriteLine(Convert.ToInt32(usersGuess));
            int Guess = Convert.ToInt32(usersGuess);
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
