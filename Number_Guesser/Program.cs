using System;

// Namespace
namespace Number_Guesser
{
    //Main Class
    internal class Program
    {
        // Entry Point Method  // Void is the return type //Static means refers to the function instead of an instance of an object
        static void Main(string[] args)
        {
            //  string name = "Good Morning";
            //int age = 38;

            //Ctrl f5 to run
            //Console.WriteLine("hello and " + name + " you are " +age+ " years old");
            //Console.WriteLine("{0} you are {1}", name, age);

            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Ruben Valdez";

            //Change text color 
            Console.ForegroundColor = ConsoleColor.Green;

            //Write out app info
            Console.WriteLine("{0} version {1} by {2}", appName, appVersion, appAuthor);

            //Reset text color
            Console.ResetColor();

            // Ask user's name 
            Console.WriteLine("What is your name");

            //Get user input
            string input = Console.ReadLine();

            Console.WriteLine("Hello {0}, I'd like to play a game", input);

            //Set correct number
            int correctNumber = 7;

            //init guess var
            int guess = 0;

            //ask user for number
            Console.WriteLine("Guess a number between 1 and 10");

            //while guess is not correct
            while (guess != correctNumber) { 
            
                guess = Console.ReadLine();
            }
    



        }
    }
}
