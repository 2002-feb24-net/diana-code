using System;
using FruitLibrary;

namespace MainFile
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            // Create customer or fetch a customer out of the database
            // Create a database of customers (Create this somewhere else)
            // Create a way to determine if it's a new or returning customer
            // Pass customer into location that they're shopping at to pass into the rest of the code
            var shop = new Store();
            shop.ShopLocation();
            shop.Welcome(); 
        }
    }
}
