using System;
using System.Collections.Generic;



namespace PersonList
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person("Brad", 21);
            Person person2 = new Person("Britney", 22);
            Person person3 = new Person("Barney", 23);
            Person person4 = new Person("Bernard", 24);
            Person person5 = new Person("Bailey", 25);

            var peopleList = new List<Person> (); 
            peopleList.Add(person1);
            peopleList.Add(person2);
            peopleList.Add(person3);
            peopleList.Add(person4);
            peopleList.Add(person5);

            Console.WriteLine(peopleList);
        /*  var firstMethod = Duplicates();
            var secondMethod = InsertionSort(int[] inputArray);
            Console.WriteLine(firstMethod);
            Console.WriteLine(secondMethod);
        }

        static bool Duplicates()
        {
                var hs = new HashSet<string>();

                for (var i = 0; i < peopleList.Count; ++i) {
                    if (!hs.Add(peopleList[i])) 
                    {
                    
                    return true;
                    }
                } else
                {
                    return false;
                }
            
            
        }

        // Using Insertion Sort to Sort through peopleList

        static int[] InsertionSort(int[] inputArray)
        {
            string[] inputArray = peopleList.ToArray();

            for (int i = 0; i < inputArray.Length - 1; i++)
            {
                for (int j = i + 1; j > 0; j--)
                {
                    if (inputArray[j - 1] > inputArray[j])
                    {
                        int temp = inputArray[j - 1];
                        inputArray[j - 1] = inputArray[j];
                        inputArray[j] = temp;
                    }
                  }
            }
            return inputArray;   */      
        } 
        //The difference between an insertion sort and a bubble sort is that an insertion sort builds 
        // the final sorted array one item at a time, whereas a bubble sort repeatedly iterates through
        // an array and swaps unsorted elements 2 at a time. 
    }
}
