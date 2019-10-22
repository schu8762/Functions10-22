using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functions10_22
{
    class Program
    {
        //@author Jacob Schuller
        static void Main(string[] args)
        {
            
           // string partOne, partTwo, result;

            Console.WriteLine("which function do you want to run? fizzbuzz, guess a number, or all of them??");
            string answer = Console.ReadLine().ToLower();

            if (answer == "fizzbuzz")
            {
                fizzBuzz();
            }
            else if (answer == "guessnumber")
            {
                guessNumber();
            }
            else if (answer == "all")
            {
                fizzBuzz();
                guessNumber();
            }
            else
            {
                Console.WriteLine("sorry that is not a function!");
            }


            Console.ReadKey();
        }

        static void fizzBuzz()
        {


            const Int32 mine = 2;
            Console.WriteLine("Enter in your favorite number!");
            int favnumber = Convert.ToInt32(Console.ReadLine());

            //int.TryParse(favnumber, out favnumberInt

            while (favnumber != mine)
            {
                Console.WriteLine("Enter in your favorite number!");
                string answer = Console.ReadLine();
                while (Int32.TryParse(answer, out favnumber) == false)
                {
                    Console.WriteLine("Invalid entry, try again");
                    Console.WriteLine("Enter in your favorite number!");
                    answer = Console.ReadLine();
                }
            }


            if (favnumber % 3 == 0 && favnumber % 5 == 0)
            {
                Console.WriteLine(favnumber + " Fizz Buzz");
            }
            else if (favnumber % 3 == 0)
            {
                Console.WriteLine(favnumber + "Fizz");
            }
            else if (favnumber % 5 == 0)
            {
                Console.WriteLine(favnumber + "Buzz");
            }
            else
            {
                Console.WriteLine(favnumber);
            }
            //return;

        }



        static void guessNumber()
        {
            //guess a number


            Random rand = new Random();
            Console.WriteLine("Please enter the minimum for your random number. >>");
            int min = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the maximum for your random number. >>");
            int max = Convert.ToInt32(Console.ReadLine());

            //If the loop starts here, we will generate a random number every ITERATION
            int generatedNumber = rand.Next(min, max + 1);

            Console.WriteLine(generatedNumber);
            int ans = 0;
            while (ans != generatedNumber)
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.WriteLine($"Please guess a number between {min} and {max}. >>");
                string answer = Console.ReadLine();
                while (Int32.TryParse(answer, out ans) == false)
                {
                    Console.WriteLine("Invalid input, please try again. >>");
                    Console.WriteLine($"Please guess a number between {min} and {max}. >>");
                    answer = Console.ReadLine();
                }

                if (ans == generatedNumber)
                {
                    Console.WriteLine("Congratulations, you guessed it!");
                }
                else
                {
                    if (ans < generatedNumber)
                    {
                        Console.BackgroundColor = ConsoleColor.Blue;
                        Console.WriteLine("Sorry your guess is too low");
                    }
                    else
                    {
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.WriteLine("Sorry your guess is too high");
                    }
                    //return;
                }


            }
        }
    }
}
