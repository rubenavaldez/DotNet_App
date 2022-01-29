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
            Console.WriteLine("{0} version {1} by {2}", appName, appVersion, appAuthor);
        }
    }
}
