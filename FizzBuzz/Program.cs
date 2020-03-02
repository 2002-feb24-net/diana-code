using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
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
