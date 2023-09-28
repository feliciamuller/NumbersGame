using System.ComponentModel.Design;
using System.Windows.Markup;

namespace NumbersGame
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Välkommen till Gissa numret! \n\n" +
                "Spelet går ut på att du ska gissa rätt nummer på fem försök! Du kommer få välja svårighetsgrad. \n\n" +
                "Tryck 1 för lätt nivå, det hemliga numret är mellan 1 - 10. \n" +
                "Tryck 2 för medel nivå, det hemliga numret är mellan 1 - 20. \n" +
                "Tryck 3 för svår nivå, det hemliga numret är mellan 1 - 30");

            int gameLevel = int.Parse(Console.ReadLine());

            //Calls different methods depending on level
            switch(gameLevel)
            {
                case 1: Program.CheckGuessEasy();
                    break;
                case 2: Program.CheckGuessMedium();
                    break;
                case 3: Program.CheckGuessHard();
                    break;

            }
        }

        static void CheckGuessHard() 
        {
            int guessCounter = 5;

            //Generate the secret number
            Random random = new Random();
            int secretNumber = random.Next(1, 30);

            do
            {
                //Decrease the amount of guesses
                guessCounter--;

                //Collect the guessed number
                Console.WriteLine("Skriv in det nummer du gissar på: ");
                int userGuess = int.Parse(Console.ReadLine());

                //Check conditions for the guessed number
                if (userGuess == secretNumber)
                {
                    Console.WriteLine("Wohoo! Du klarade det!");
                    break;

                }

                else if (userGuess < secretNumber)
                {
                    if (userGuess == secretNumber - 1)
                    {
                        Console.WriteLine($"Nu var du väldigt nära, lite för lågt bara! Du har {guessCounter} försök kvar");
                    }

                    else
                    {
                        Console.WriteLine($"Tyvärr, du gissade för lågt! Du har {guessCounter} försök kvar");
                    }

                }

                else if (userGuess > secretNumber)
                {
                    if (userGuess == secretNumber + 1)
                    {
                        Console.WriteLine($"Nu var du väldigt nära, lite för högt bara! Du har {guessCounter} försök kvar");
                    }

                    else
                    {
                        Console.WriteLine($"Tyvärr, du gissade för högt! Du har {guessCounter} försök kvar");
                    }

                }

                if (guessCounter == 0)
                {
                    Console.WriteLine("Tyvärr, du lyckades inte gissa talet på fem försök!");
                }


            } while (guessCounter != 0);

            Console.WriteLine("Spelet är slut!");
        }

        static void CheckGuessMedium() 
        {
            int guessCounter = 5;

            //Generate the secret number
            Random random = new Random();
            int secretNumber = random.Next(1, 20);

            do
            {
                //Decrease the amount of guesses
                guessCounter--;

                //Collect the guessed number
                Console.WriteLine("Skriv in det nummer du gissar på: ");
                int userGuess = int.Parse(Console.ReadLine());

                //Check conditions for the guessed number
                if (userGuess == secretNumber)
                {
                    Console.WriteLine("Wohoo! Du klarade det!");
                    break;

                }

                else if (userGuess < secretNumber)
                {
                    if (userGuess == secretNumber - 1)
                    {
                        Console.WriteLine($"Nu var du väldigt nära, lite för lågt bara! Du har {guessCounter} försök kvar");
                    }

                    else
                    {
                        Console.WriteLine($"Tyvärr, du gissade för lågt! Du har {guessCounter} försök kvar");
                    }

                }

                else if (userGuess > secretNumber)
                {
                    if (userGuess == secretNumber + 1)
                    {
                        Console.WriteLine($"Nu var du väldigt nära, lite för högt bara! Du har {guessCounter} försök kvar");
                    }

                    else
                    {
                        Console.WriteLine($"Tyvärr, du gissade för högt! Du har {guessCounter} försök kvar");
                    }


                }

                if (guessCounter == 0)
                {
                    Console.WriteLine("Tyvärr, du lyckades inte gissa talet på fem försök!");
                }


            } while (guessCounter != 0);

            Console.WriteLine("Spelet är slut!");

        }

        static void CheckGuessEasy() 
        {
            int guessCounter = 5;

            //Generate the secret number
            Random random = new Random();
            int secretNumber = random.Next(1, 10);

            do
            {
                //Decrease the amount of guesses
                guessCounter--;

                //Collect the guessed number
                Console.WriteLine("Skriv in det nummer du gissar på: ");
                int userGuess = int.Parse(Console.ReadLine());

                //Check conditions for the guessed number
                if (userGuess == secretNumber)
                {
                    Console.WriteLine("Wohoo! Du klarade det!");
                    break;

                }

                else if (userGuess < secretNumber)
                {
                    if (userGuess == secretNumber - 1)
                    {
                        Console.WriteLine($"Nu var du väldigt nära, lite för lågt bara! Du har {guessCounter} försök kvar");
                    }

                    else
                    {
                        Console.WriteLine($"Tyvärr, du gissade för lågt! Du har {guessCounter} försök kvar");
                    }

                }

                else if (userGuess > secretNumber)
                {
                    if (userGuess == secretNumber + 1)
                    {
                        Console.WriteLine($"Nu var du väldigt nära, lite för högt bara! Du har {guessCounter} försök kvar");
                    }

                    else
                    {
                        Console.WriteLine($"Tyvärr, du gissade för högt! Du har {guessCounter} försök kvar");
                    }


                }

                if (guessCounter == 0)
                {
                    Console.WriteLine("Tyvärr, du lyckades inte gissa talet på fem försök!");
                }


            } while (guessCounter != 0);

            Console.WriteLine("Spelet är slut!");

        }
  

    }
}