using System;

namespace Week4_NumberGuesser
{
    class Program
    {
        static void Main(string[] args)
        {
            GetAppInfo();

            GreetUser();

            while (true)
            {


                //Init correct number
                //int correctNumber = 5;

                //create a new random object
                Random random = new Random();

                int correctNumber = random.Next(1, 11);

                //Init guess var
                int guess = 0;

                //Ask user for number
                Console.WriteLine("Guess a number between 1 and 10");

                //While guess is not correct
                while (guess != correctNumber)
                {
                    //Get users input
                    string UserInput = Console.ReadLine();

                    //Make sure the input is a number
                    if (!int.TryParse(UserInput, out guess))
                    {
                        //Print error message
                        PrintColorMessage(ConsoleColor.Red, "Use an actual number you nonce");

                        //keep going
                        continue;
                    }

                    //Cast to int to put in guess
                    guess = Int32.Parse(UserInput);

                    //Match guess to correct number
                    if (guess != correctNumber)
                    {
                        //Print error message
                        PrintColorMessage(ConsoleColor.Red, "Wrong number, try again");
                    }
                }
                //Print success message
                PrintColorMessage(ConsoleColor.Green, "You are correct!");

                //Ask to play again
                Console.WriteLine("Play again?[Y or N]");

                //Get answer
                string answer = Console.ReadLine().ToUpper();

                if(answer == "Y")
                {
                    continue;
                }
                else if(answer == "N")
                {
                    return;
                }
            }
        }

        static void GetAppInfo()
        {
            //set app vars
            string appName = "Number Guesser";
            string appVersion = "2.0";
            string appAuthor = "Kaler Kusik";

            //Change text color
            Console.ForegroundColor = ConsoleColor.DarkMagenta;

            //App info
            Console.WriteLine($"{appName}: {appVersion} by {appAuthor}");

            //Change text color back
            Console.ResetColor();
        }

        static void GreetUser()
        {
            //Ask users name
            Console.WriteLine("Pick your username");

            //Get user input
            string Username = Console.ReadLine();

            Console.WriteLine($"Hello {Username}, let's play Number Guesser!");
        }
        static void PrintColorMessage(ConsoleColor color, string message)
        {
            //Change text color
            Console.ForegroundColor = color;

            //Tell user its not a number
            Console.WriteLine(message);

            //Change text color back
            Console.ResetColor();
        }
    }
}


    