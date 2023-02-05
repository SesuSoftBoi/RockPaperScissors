using System;

namespace RockPaperScissors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string value;
            do
            {
                Console.WriteLine("Rock, Paper, Scissors Game: ");
                Console.WriteLine("Please choose Rock (R), Paper (P), or Scissors (S): ");

                string playerChoice = Console.ReadLine();

                if (playerChoice == "R" || playerChoice == "P" || playerChoice == "S")
                {
                    string computerChoice = GetComputerChoice();
                    Console.WriteLine($"Computer Choice: {computerChoice}");

                    string result = GetResult(playerChoice, computerChoice);
                    Console.WriteLine($"Result: {result}");
                }
                else
                {
                    Console.WriteLine("Invalid choice. Please pick R, P, or S.");
                }

                Console.Write("Do you want to continue(y/n):");
                value = Console.ReadLine();
            }
            while (value == "y" || value == "Y");

            static string GetComputerChoice()
            {
                Random random = new Random();
                int choice = random.Next(3);

                if (choice == 0)
                {
                    return "R";
                }
                else if (choice == 1)
                {
                    return "P";
                }
                else
                {
                    return "S";
                }

            }

            static string GetResult(string playerChoice, string computerChoice)
            {
                if (playerChoice == computerChoice)
                {
                    return "Draw!";
                }
                else if (playerChoice == "R" && computerChoice == "S")
                {
                    return "You win!";
                }
                else if (playerChoice == "P" && computerChoice == "R")
                {
                    return "You win!";
                }
                else if (playerChoice == "S" && computerChoice == "P")
                {
                    return "You win!";
                }
                else
                {
                    return "Computer wins!";
                }
            }
        }
    }
}