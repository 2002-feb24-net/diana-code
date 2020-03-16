using System;

namespace palindrome
{
    public class Class1: IPalindrome
    {
            public bool Palindrome(string word)
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
