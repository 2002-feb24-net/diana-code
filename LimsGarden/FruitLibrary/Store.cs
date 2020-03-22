using System;

namespace FruitLibrary 
{
    public class Store  
    {
        public void Welcome()
        {
            Console.Clear();
            Console.WriteLine("Welcome to Lim's Garden!");
            Console.WriteLine();
            Console.WriteLine("How may we help you today?");
            Console.WriteLine();
            Console.WriteLine("To buy Fruit, press f");
            Console.WriteLine("To buy Vegetables, press v");
            Console.WriteLine("To buy A Plant, press p");
            string category = Console.ReadLine();

// Fruit Buying Options

            if(category == "f")
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
                }
                else if(fruitChoice == "Nectarine")
                {
                    Console.Clear();
                    Console.WriteLine("How many would you like?");
                    string amount = Console.ReadLine();
                }
                else if(fruitChoice == "Loquat")
                {
                    Console.Clear();
                    Console.WriteLine("How many would you like?");
                    string amount = Console.ReadLine();
                }
                else if(fruitChoice == "Asian Apple")
                {
                    Console.Clear();
                    Console.WriteLine("How many would you like?");
                    string amount = Console.ReadLine();
                }
                else 
                {
                    Console.Clear();
                    Console.WriteLine("Error: Please check item name spelling, and try again.");
                    // Create a way to return to beginning of fruit prompt
                }

            }

// Vegetable Buying Options
            
            else if(category == "v")
            {
                Console.Clear();
                Console.WriteLine("What kind of vegetable would you like to buy?");
                Console.WriteLine();
                Console.WriteLine("Cucumber");
                Console.WriteLine("Asparagus");
                Console.WriteLine("Carrot");
                Console.WriteLine("Bell Pepper");
                string fruitChoice = Console.ReadLine();
                if(fruitChoice == "Cucumber")
                {
                    Console.Clear();
                    Console.WriteLine("How many would you like?");
                    string amount = Console.ReadLine();
                }
                else if(fruitChoice == "Asparagus")
                {
                    Console.Clear();
                    Console.WriteLine("How many would you like?");
                    string amount = Console.ReadLine();
                }
                else if(fruitChoice == "Carrot")
                {
                    Console.Clear();
                    Console.WriteLine("How many would you like?");
                    string amount = Console.ReadLine();
                }
                else if(fruitChoice == "Bell Pepper")
                {
                    Console.Clear();
                    Console.WriteLine("How many would you like?");
                    string amount = Console.ReadLine();
                }
                else 
                {
                    Console.Clear();
                    Console.WriteLine("Error: Please check item name spelling, and try again.");
                    // Create a way to return to beginning of fruit prompt
                }

            }

// Plant Buying Options
            
            else if(category == "p")
            {
                Console.Clear();
                Console.WriteLine("What kind of plant would you like to buy?");
                Console.WriteLine();
                Console.WriteLine("Loquat Tree");
                Console.WriteLine("Nectarine Tree");
                Console.WriteLine("Lemon Tree");
                Console.WriteLine("Rose Bush");
                string fruitChoice = Console.ReadLine();
                if(fruitChoice == "Loquat Tree")
                {
                    Console.Clear();
                    Console.WriteLine("How many would you like?");
                    string amount = Console.ReadLine();
                }
                else if(fruitChoice == "Nectarine Tree")
                {
                    Console.Clear();
                    Console.WriteLine("How many would you like?");
                    string amount = Console.ReadLine();
                }
                else if(fruitChoice == "Lemon Tree")
                {
                    Console.Clear();
                    Console.WriteLine("How many would you like?");
                    string amount = Console.ReadLine();
                }
                else if(fruitChoice == "Rose Bush")
                {
                    Console.Clear();
                    Console.WriteLine("How many would you like?");
                    string amount = Console.ReadLine();
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
}
