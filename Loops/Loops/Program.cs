using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
                      //CHALLENGE

            Console.WriteLine("Enter your number");
            string input = "0";
            int counter = 0;
            int total = 0;
            int currentNumber = 0;

           while ( input != "-1")
            {
                Console.WriteLine("Last number was {0}", currentNumber);
                Console.WriteLine("Please, enter the next score");
                Console.WriteLine("Current emount of entries {0}", counter);

                input = Console.ReadLine();
                if (input.Equals("-1"))
                {
                    Console.WriteLine("-------------------------------------------");
                    double average = (double)total / (double)counter;
                    Console.WriteLine(" The average is {0}", average);
                }
                if( int.TryParse (input, out currentNumber) && currentNumber > 0 && currentNumber < 21)
                {
                    total = total + currentNumber;
                }
                else
                {
                    if (!(input.Equals("-1")))
                    {
                        Console.WriteLine("Please enter a value between 1 and 20!");
                    }
                    continue;
                }
                counter++;
            }
            
                     
                     
             Console.ReadLine();
        }
    }
}
