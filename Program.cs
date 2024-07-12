using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberGuessingGame
{
    internal class Program
    {
        static void Main(String[] args)
        {
            bool playAgain = true;
            Console.WriteLine("Guess the correct number between 1-10 to winnn");
            while (playAgain)
            {
                GameResults();
                Console.WriteLine("Do you want to play again? (y/n)");
                string choice = Console.ReadLine().ToLower();
                if(choice != "y")
                    playAgain = false;
            }
        }
        static void GameResults() {
            Random rnd = new Random();
            int randomNumber = rnd.Next(1,11);
            int attempts = 3, guessedNumber = 0;
            bool guessedCorrectly = false;
            for (int i = 1; i <= attempts; i++)
            {
                Console.WriteLine("Enter the number: ");
                guessedNumber = Convert.ToInt32(Console.ReadLine());
                if (guessedNumber < 1 || guessedNumber > 10)
                    Console.WriteLine("Invalid input! Enter a number in the range 1-10");
                else
                {
                    if (guessedNumber == randomNumber)
                    {
                        Console.WriteLine("Congratulations! You guessed the number right in " + i + " attempts");
                        guessedCorrectly = true;
                        break;
                    }
                    else if (guessedNumber < randomNumber)
                        Console.WriteLine("Try again! Too low");
                    else 
                        Console.WriteLine("Try again! Too high");
                    //if (guessedNumber > randomNumber)
                }
            }
            if (!guessedCorrectly)
            {
                Console.WriteLine("Sorry! You've used all your attempts. The correct number was " + randomNumber);
            }
        }
    }
}
