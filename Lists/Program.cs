using System;

namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            // like arrays, each List instance can contain
            // just one particular type of data, which you choose when you create the list.

            // unlike arrays, Lists can grow and shrink in size.

            List<int> numbers = new Lists<int>();
            // starts empty by default
            int howMany = numbers.Count; //0
            numbers.Add(123); // adds to the end of the list
            // now numbers.Count == 1
            int firstItem = numbers[0]; // works just like an array.
            int thirdItem = numbers[2] // just like an array, you will get an error if you access what isn't there.

            numbers[0] = 5; // you can change the contents
            numbers.Insert(0, 1000) // add 1000 at index 0 (the beginning) 
            // (now 123 is at index 1; it got pushed forward
            numbers.Contain

            // declare a variable to hold each item of the list or array one by one
            foreach (int num in numbers)
            {
                sum += num;
            }
            // now sum has the sum of all the numbers
            // you can use foreach
        }
    }
}
