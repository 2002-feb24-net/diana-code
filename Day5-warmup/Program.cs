using System;

namespace Warmup1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please type in a multi-term word.");
            string contain = Console.ReadLine();

            string[] containSplit = contain.Split(" ");
            foreach (string res in containSplit) {
            Console.Write(res.Substring(0,1).ToUpper());
            }
        }
    }
}
