using System;

namespace FizzBuzz
{
    class Program
    {
        /*Task Description:
            For each number from 1 to 1000 in order,
            * print "Fizz" for the ones divisible by 3 (& not 5)
            * print "Buzz" for the ones divisible by 5 (& not 3)
            * print "Fizzbuzz" for the ones divisible by both 3 and 5
            * print the number itself, for all the rest of the numbers
            Also, I want to know, at the end, how many Fizz, how many Buzz, how many Fizzbuzz.
            Your code should calculate that, and, put the numbers you get in a comment, so I
            can see them without running the code. */
        static void Main(string[] args)
        {
            string fizz = 0;
            strin
            for (int i = 1; i <= 1000; i++)
            {
                if((i % 3 == 0) && (i % 5 != 0))
                {
                    Console.WriteLine("Fizz");      
                }
                else if(i % 5 == 0 && i % 3 != 0)
                {
                    Console.WriteLine("Buzz");
                }
                else if(i % 5 == 0 && i % 3 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
                //I don't know how to calculate how many Fizz, Buzz, and FizBuzz there are combined, so I'm going to guess
                //There are 300 Fizz's, 300 Buzz's, and 30 FizzBuzz's. 
            }
        }
    }
}
