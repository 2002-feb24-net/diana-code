using System;

namespace FruitLibrary 
{
    public class Fruit: Plant  
    {
        public void FruitOptions()
        {
                Console.Clear();
                Console.WriteLine("What kind of fruit would you like to buy?");
                Console.WriteLine();
                Console.WriteLine("Watermelon");
                Console.WriteLine("Nectarine");
                Console.WriteLine("Loquat");
                Console.WriteLine("Asian Apple");
                string fruitChoice = Console.ReadLine();
                if(fruitChoice == "Watermelon")
                {
                    Console.Clear();
                    Console.WriteLine("How many would you like?");
                    string amount = Console.ReadLine();
                    Console.WriteLine("Great! Your total is: ");
                }
                else if(fruitChoice == "Nectarine")
                {
                    Console.Clear();
                    Console.WriteLine("How many would you like?");
                    string amount = Console.ReadLine();
                    Console.WriteLine("Great! Your total is: ");
                }
                else if(fruitChoice == "Loquat")
                {
                    Console.Clear();
                    Console.WriteLine("How many would you like?");
                    string amount = Console.ReadLine();
                    Console.WriteLine("Great! Your total is: ");
                }
                else if(fruitChoice == "Asian Apple")
                {
                    Console.Clear();
                    Console.WriteLine("How many would you like?");
                    string amount = Console.ReadLine();
                    Console.WriteLine("Great! Your total is: ");
                }
                else 
                {
                    Console.Clear();
                    Console.WriteLine("Error: Please check item name spelling, and try again.");
                    // Create a way to return to beginning of fruit prompt
                }
        }
        
    }

}