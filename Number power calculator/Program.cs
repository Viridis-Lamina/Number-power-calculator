using System;

namespace MethodPower
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello and welcome to the Power calculator this application can Square and Cube Numbers for you");
            Console.WriteLine();
            Console.WriteLine("Please enter a number");
            int number = int.Parse(Console.ReadLine());
            int Squared = Square(number);
            int Cubed = Cube(number);
            
            Console.WriteLine("This number Squared is {0} and this number Cubed is {1}", Squared, Cubed);
            Console.WriteLine();
            Console.WriteLine("Do you want to see the calculations? Y or N");
            
            if (Console.ReadKey(true).Key == ConsoleKey.Y)
            {
                Console.WriteLine();
                Console.WriteLine("For the square calculation it is {0,2}  * {1,2} = {2,2}", number, number, Squared);
                Console.WriteLine();
                Console.WriteLine("For the Cube calculation it is {0,2}  * {1,2} = {2,2}", Squared, number, Cubed);
            }

            if (Console.ReadKey(true).Key == ConsoleKey.N)
            {
                Console.WriteLine();
                Console.WriteLine("Ok thank you for using this application");
                ;
            }


        }

        public static int Square (int number)
        {
            int answer = number * number;
            return answer;

            }

        public static int Cube (int number)
        {
            int answer = Square(number) * number;
            return answer;

        }
        }
    }

