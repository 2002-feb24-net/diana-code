using System;

namespace HashSet
{
    class Program
    {
        static void Main(string[] args)
        {
           HashSet<string> bagofStrings = new HashSet<string>();

           bagOfStrings.Add("Russel");
           bagOfStrings.Add("Mahir");
           bagOfStrings.Add("Paul");
           bagOfStrings.Add("Paul"); // this does nothing at all

           Console.WriteLine(bagofStrings.Count); // 3

           bool isPaulHere = bagofStrings.Contains("Paul"); //true
           bagOfStrings.Remove("Paul");

            // UnionWith is same as AddRange on List
           bagOfStrings.UnionWith(new string[] {"abc", "bca", "b"});

        }
    }
}
