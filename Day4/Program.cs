using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Problem1();
            //Problem2("ahdgfhf", 2);
        }

        static void Problem1()
        {
            Console.WriteLine("How old are you in seconds?");
            string age = Console.ReadLine();

            Console.WriteLine("What planet are you from?");
            string planet = Console.ReadLine();

            double planetAge = 0;


            switch (planet)
            {
                case "Mercury":
                planetAge = (double.Parse(age))/7600000;
                break;

                case "Venus":
                planetAge = (double.Parse(age))/19400000;
                break;

                case "Earth":
                planetAge = (double.Parse(age))/31600000;
                break;

                case "Mars":
                planetAge = (double.Parse(age))/59400000;
                break;

                case "Jupiter":
                planetAge = (double.Parse(age))/370000000;
                break;

                case "Saturn":
                planetAge = (double.Parse(age))/930000000;
                break;

                case "Uranus":
                planetAge = (double.Parse(age))/2700000000;
                break;

                case "Neptune":
                planetAge = (double.Parse(age))/5200000000;
                break;
            }
            
            Console.WriteLine("You are " + planetAge + " years old!");

        }

     /*    static void Problem2(string Name, int Number) 
        {
            //Store the string into an array
            string[] myStrings = new string[Name.Length];

            //Craete a for loop to fill the array with each Char
            
            for(int i = 0; i < Name.Length; i++)
            {
                myStrings[i] = Name.Substring(0,0);
                Name.TrimStart();
            }

            combineString(Name.Length, myStrings, Number);
        }
        static void combineString(int nameLength, string[] stringArray, int jump)
        {
            for(int i = 0; i < nameLength; i++)
            {
                int times = 0;
                if(i + jump > nameLength)
                {

                } else if (i + jump < nameLength)
                {
                    while(times < jump)
                    {
                        Console.Write(stringArray[i + times]);
                        times++;
                    }
                } else 
                {
                    while(times < nameLength - i)
                    {
                        Console.Write(stringArray[i + times]);
                        times++;
                    }
                    Console.WriteLine();
                }
                
            }
        } 
        */

    }
}
