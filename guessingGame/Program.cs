using System;

namespace guessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("??Guess the secret number??");
            string usersGuess = Console.ReadLine();
            Console.WriteLine(Convert.ToInt32(usersGuess));
        }
    }
}
