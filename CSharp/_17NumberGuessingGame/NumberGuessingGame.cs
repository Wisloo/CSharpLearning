namespace _17NumberGuessingGame;
using System;
public class NumberGuessingGame
{
    public static void Main(string[] args)
    {
        Random random = new Random();
        bool playAgain = true;
        int min = 1, max = 100, guess, number, guesses;

        while (playAgain)
        {
            guess = 0; // number that the user will guess
            guesses = 0; // number of time the user has guessed
            String response = ""; // response for playAgain
            number = random.Next(min, max + 1); // initialization of the number to be guessed

            while (guess != number) // while loop that continues to run while guess is not equal to number
            {
                Console.WriteLine("Guess a number between " + min + " - " + max + " : ");
                guess = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Guess: " + guess);

                if (guess > number) // if else statement for when the user input number doesn't correspond to the random number given by the system 
                {
                    Console.WriteLine(guess + " is too high :>");
                } else if (guess < number)
                {
                    Console.WriteLine(guess + " is too low :>");
                }
                guesses++; // iterates the guesses, adds 1
            }

            Console.WriteLine("Number: " + number);
            Console.WriteLine("YOU WIN!");
            Console.WriteLine("Guesses: " + guesses);
            Console.WriteLine("Would you like to play again? (Yes/No): ");
            response = Console.ReadLine();
            response = response.ToUpper();

            if (response == "YES") // changes the value of the boolean "playAgain" depending on the user response
            {
                playAgain = true;
            }
            else
            {
                playAgain = false;
            }

            Console.WriteLine("Thanks for playing! Hope you enjoyed!");
        }
    }
}