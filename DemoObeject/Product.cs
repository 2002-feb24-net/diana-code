using System;

namespace DemoObeject
{
    class Product
    {
        // Below are fields, not variables.
        // These will only be accessible inside this class.
        string ProductId;
        int Stock;
        double StarRating;

        //There are 2 types of methods in C#
        // Static methods do not require an object instance.
                //One copy of that thing for the whole program.
        // Non-static/instance methods exist on one particular object at a time.
        public void SetDefaultValues()
        {
            ProductId = "1";
            Stock = 0;
            StarRating = 5;
        }

        public void SetValues(string id, int quantity, double rating)
        {
            // Business logic like "no product can have more than 50 quantity"
            // Belongs in the classes that represent those entities
            // Not in input/output code
            if(quantity > 50)
            {
                Console.WriteLine("Error! Too many items!");
            }
            if(quantity < 0)
            {
                Console.WriteLine("Error! Can't have negative quantity.");
            }
            ProductId = id;
            Stock = quantity;
            StarRating = rating;
        }

        public override string ToString()
        {
            return "product " + ProductId + ", " + Stock + " in stock, " + StarRating + "star rating";
        }
    }
}