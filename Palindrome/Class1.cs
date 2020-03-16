using System;
using Task;


namespace palindrome
{
    public class Palindrome: IPalindrome
    {
            public bool MakePalindrome(string word)
        {
            // my previous regex /[^0-9a-zA-Z]/g,''
            word = word.Replace(@"^\w+$","").ToLower();
            string wordForward = word;
            string wordBackward = "";
            for(int i = word.Length-1; i >= 0; i--)
            {
                wordBackward = wordBackward + wordForward[i];
            }

       
           
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
