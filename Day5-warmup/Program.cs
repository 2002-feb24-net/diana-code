using System;

namespace Warmup1
{
    class Program
    {
        //Task description: Create a program that asks for a multi-term word and prints the acronym for each word.
        static void Main(string[] args)
        {
            // My Process:
            // 1. Ask for a multi-term word and store it in a variable.
            Console.WriteLine("Please type in a multi-term word.");
            string contain = Console.ReadLine();

            // 2. Split each word and store it into an array.
            string[] containSplit = contain.Split(" ");
            
            // 3. Loop through each word and print the first letter of each in uppercase.
            foreach (string res in containSplit) {
            Console.Write(res.Substring(0,1).ToUpper());
            }
        }
    }
}
