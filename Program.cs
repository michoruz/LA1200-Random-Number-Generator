using System;

namespace RandomNumberGenerator
{
    class Program
    {

        static void Main(string[] args)
        {
            // WILLKOMMEN (Titel)
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(Figgle.FiggleFonts.Slant.Render("GuessTheRandomNumber"));
            Console.ForegroundColor = ConsoleColor.White;
            
            // Variablendeklaration
            Random rand = new Random();
            int guess = 0;
            string start = "Guess a number between 1 and 100";
            int num = rand.Next(1, 100);
            int i = 0;
            string space = "------------------------------------------------------------------------------------------";

            // Ausgabe
            Console.WriteLine("Welcome! If you wanna finish this as fast as possible, just do what the console says!");
            Console.WriteLine(space);
            Console.WriteLine(start);
            Console.WriteLine(space);
            
            while (guess != num)
            {
                try
                {
                    guess = Convert.ToInt32(Console.ReadLine());

                    if (guess > num)
                    {
                        // Anzeige bei zu hoher Zahl
                        Console.ForegroundColor = ConsoleColor.DarkRed;
                        Console.WriteLine("go lower!");
                    }
                    if (guess < num)
                    {
                        // Anzeige bei zu niedriger Zahl
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.WriteLine("go higher!");
                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                    }
                    if (guess == num)
                    {
                        // Anzeige beim Erraten der Zahl
                        Console.ForegroundColor = ConsoleColor.DarkGreen;
                        Console.WriteLine("got it!");
                    }
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine(space);
                }
                // Anzeige bei einer Fehleingabe
                catch
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("you gotta type in a number, NO SIGNS!");
                    Console.Beep();
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine(space);
                    i--;
                }

               i++;
            }
            // Anzahl Versuche beim Raten der Zahl

            if (guess < 2)
            {
                Console.WriteLine("damn, you only needed " + i + " attempt!");
            }
            else
            {
                Console.WriteLine("damn, you only needed " + i + " attempts!");
            }
            // Ende des Ratens
            Console.WriteLine(space);
            Console.WriteLine("thank you for trying it out! please press ''ENTER'' twice to exit the program. ");
            Console.ReadLine();
        }
    }
}