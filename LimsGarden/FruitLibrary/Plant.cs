using System;

namespace FruitLibrary 
{
    public abstract class Plant  
    {
        public virtual string name { get; set; }
        public virtual int price { get; set; }
        public virtual int count { get; set;}

        public virtual bool ToBuy()
        {
            Console.WriteLine($"Would you like to purchase this {this.name} ? y/n");
            var response = Console.ReadLine();
            if(response == "y")
            {
            Console.WriteLine($"{this.name} costs {this.price}");
            return true;
            } else if (response == "n")
            {
                Console.WriteLine("Okay. Thank you. Bye!");
            }
            return false;
        }

    }
}