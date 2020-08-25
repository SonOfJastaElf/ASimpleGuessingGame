using System;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("I'm thinking of a number between 1 and 1000.  Can you guess what it is?");
            
            var r = new Random();
            var computerNumber = r.Next(1, 1000);

            Console.WriteLine("Give it a try:");

            var userInput = int.Parse(Console.ReadLine());

            if (userInput > computerNumber)
            {
                Console.WriteLine("That's too high.");
            }

            else if (userInput < computerNumber)
            {
                Console.WriteLine("That's too low.");
            }

            else
            {
                Console.WriteLine("Exactly!");
            }
        }
    }
}
