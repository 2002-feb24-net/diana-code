using System;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        public static string Palindrome(string word)
        {
            // my previous regex /[^0-9a-zA-Z]/g,''
            string word = word.Replace(@"^\w+$","").ToLower();
            string wordForward = word;
            string wordBackward = word.Split("").Reverse().Join("");
            if(wordForward == wordBackward)
            {
                return true;
            } else
            {
                return false;
            }
        } 
    }
}
