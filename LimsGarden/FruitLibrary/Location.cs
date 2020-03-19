using System;
using System.Collections.Generic;

namespace FruitLibrary 
{
    public abstract class Location  
    {
        public virtual string address { get; set; }
        public virtual List<Plant> inventory { get; set;}

        public virtual int ToSell()
        {
            
        } 


    }
}