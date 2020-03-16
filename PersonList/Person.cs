using System;

namespace PersonList
{
    class Person
    {
        private string Name { get; set; }
        private int Age { get; set; }

        public Person (string name, int age)
        {
            this.Name = name;
            Age = age;
        }
    }
}
