using System;

namespace DemoObeject
{
    class Program
    {
        static void Main(string[] args)
        {
           // Now that we've defined a class, we can create objects from that class
           // The class serves as a template to create the object
           int candyBarAmount = GetStock("candy bar");

           Product candyBar = new Product();
           candyBar.SetValues("21", 4, 4.5);
           Console.WriteLine(candyBar);

           int cerealAmount = GetStock("cereal");


           Product cereal = new Product();
           cereal.SetValues("1", 14, 3.2);
           Console.WriteLine(cereal);
        }

        static int GetStock(string name)
        {
            int quantity;
            do 
            {
            Console.Write("Enter quantity of product" + name + ": ");
            quantity = int.Parse(Console.ReadLine());
            
            } while (quantity < 0); //if negative quantity, prompt again
            // if we got this far, the user must have entered the the right input
            return quantity;
        }
    }
}
