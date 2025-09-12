using System.Net.Http.Headers;

namespace _18RockPapercissorsGame;
using System;
public class RockPaperScissorsGame
{
    public static void Main(string[] args)
    {
        Random random = new Random();
        bool playAgain = true;
        string player, computer, answer;
        
        while (playAgain)
        {
            player = "";
            computer = "";
            answer = "";
            while (player != "rock" && player != "paper" && player != "scissors")
            {
                Console.Write("Enter Rock, Paper, or Scissors: ");
                player = Console.ReadLine();
                player = player.ToLower();
            }

            
            switch (random.Next(1, 4)) 
            {
                case 1:
                    computer = "rock";
                    break;
                case 2:
                    computer = "paper";
                    break;
                case 3:
                    computer = "scissors";
                    break;
            }

            Console.WriteLine("Player: " + player);
            Console.WriteLine("Computer: " + computer);

            switch (player)
            {
                case "rock":
                    if (computer == "rock")
                    {
                        Console.WriteLine("It is a draw");
                    } else if (computer == "paper")
                    {
                        Console.WriteLine("Computer wins");
                    } else if (computer == "scissors")
                    {
                        Console.WriteLine("Player wins");
                    }
                    break;
                case "paper":
                    if (computer == "rock")
                    {
                        Console.WriteLine("Player wins");
                    } else if (computer == "paper")
                    {
                        Console.WriteLine("It is a draw");
                    } else if (computer == "scissors")
                    {
                        Console.WriteLine("Computer wins");
                    }
                    break;
                case "scissors":
                    if (computer == "rock")
                    {
                        Console.WriteLine("Computer wins");
                    } else if (computer == "paper")
                    {
                        Console.WriteLine("Player wins");
                    } else if (computer == "scissors")
                    {
                        Console.WriteLine("It is a draw");
                    }
                    break;
            }

            Console.Write("Would you like to play again? (Yes/No): ");
            answer = Console.ReadLine();
            answer = answer.ToLower();

            if (answer == "yes")
            {
                playAgain = true;
            } else if (answer == "no")
            {
                playAgain = false;
                Console.WriteLine("Thank you for playing!");
            }
            else
            {
                Console.WriteLine("Invalid answer!");
            }
            
        }
    }
}