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

            //Run get app info function 
            GetAppInfo();

            // Ask user's name 
            Console.WriteLine("What is your name");

            //Get user input
            string inputName = Console.ReadLine();

            Console.WriteLine("Hello {0}, I'd like to play a game", inputName);

            //Set correct number
            //int correctNumber = 7;

            //Create an on-going loop
            while (true){

            //Create a random number 
            Random random = new Random();

            int correctNumber = random.Next(1,10);

            //init guess var
            int guess = 0;

            //ask user for number
            Console.WriteLine("Guess a number between 1 and 10");

            //while guess is not correct
            while (guess != correctNumber) { 
                //get user input
                string input = Console.ReadLine();

                //make sure it's a number
                if (!int.TryParse(input, out guess)) {
                    //Change text color 
                    Console.ForegroundColor = ConsoleColor.Red;

                    //Tell User it's not a number
                    Console.WriteLine("Please enter an actual number");

                    //Reset text color
                    Console.ResetColor();

                    continue;
                }


                //Cast to interger and save in guess variable 
                guess = Int32.Parse(input);

                //match guess to correct number

                if(guess != correctNumber){
                    //Change text color 
                    Console.ForegroundColor = ConsoleColor.Red;

                    //Tell User it's the wrong number
                    Console.WriteLine("Wrong number, please try again");

                    //Reset text color
                    Console.ResetColor();

                }
            }


            //Change text color 
            Console.ForegroundColor = ConsoleColor.Yellow;

            //Tell User it's the right number 
            Console.WriteLine("You are correct! Great Job");

            //Reset text color
            Console.ResetColor();

            // Ask to play again
            Console.WriteLine("Play Again? [Y or N]");

            // Get Answer
            string answer = Console.ReadLine().ToUpper();

                if (answer == "Y")
                {
                    continue;
                }
                else if (answer == "N")
                {
                    return;
                }
                else {
                    return;
                    
                }
            }

        } // end while loop


        static void GetAppInfo() {
            //set app info
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Ruben Valdez";

            //Change text color 
            Console.ForegroundColor = ConsoleColor.Green;

            //Write out app info
            Console.WriteLine("{0} version {1} by {2}", appName, appVersion, appAuthor);

            //Reset text color
            Console.ResetColor();

        }
    }
}
