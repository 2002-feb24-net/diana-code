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
            string word = word.Replace(/[^0-9a-zA-Z]/g,'').ToLower();
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
