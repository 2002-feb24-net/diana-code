using System;

namespace PersonList
{
    class Person
    {
        private string Name { get; set; }
        private int Age { get; set; }

        public Person (string Name, int age)
        {
            this.Name = Name;
            this.Age = age;
        }

        public Person()
        {
            this.Name = "Jane Doe";
        }

        public override string ToString()
        {
            //return "Person: " + Name + " " + Age;
            return "Person: " + Name ;
        }        
    }
}
