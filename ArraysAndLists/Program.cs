using System;
using System.Collections.Generic;


namespace ArraysAndLists
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO:

            // Create an int Array and populate numbers 1-10        -done
            var numbers = new int[] {1,2,3,4,5,6,7,8,9,10};
            /* Create two Lists of type int.                        -done
             * Name one List "evens"                                -done
             * Name the other List "odds"                           -done
             */
            var evens = new List<int>();
            var odds = new List<int>();

            /* Using either a foreach or for loop,                  -done
             * nest an if statement to check to see                 -done
             *  if a number is even or odd.                         -done
             * Then add those numbers to either the evens List      -done  
             * or the odds List                                     -done
             */
            foreach (var number in numbers)
            {
                //var answer = (number % 2 == 0) ? evens.Add(number) : odds.Add(number); //Not working
                if (number % 2 == 0)
                {
                    evens.Add(number);
                }
                else
                {
                    odds.Add(number);
                }
            }
            /* Now using foeach or for loops,                       -done
             * display each List of even and odd numbers            -done
             *
             * Try to be creative in your display                   -done?
             */
            Console.WriteLine($"The list of evens is as follows:");
            foreach(var number in evens)
            {
                Console.WriteLine(number);
            }   
            Console.WriteLine($"The list of odds is as follows:");
            foreach(var number in odds)
            {
                Console.WriteLine(number);
            }
        }
    }
}
