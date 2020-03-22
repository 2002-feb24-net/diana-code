using System;
using System.Collections.Generic;

namespace FruitLibrary 
{
    public abstract class Location  
    {
        public virtual string address { get; set; }
        public virtual List<Plant> inventory { get; set;}

       // public virtual int Sold();
       // {

        //} 
        // I want to know which item in List I am working with
        // I want to receive the true or false value of whether or not they want to buy the plant
        // I want to get user input for how many items they want to buy
        // I want to add up the price total and send it to the Order class


    }
}