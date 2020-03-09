using System;

namespace PersonList
{
    class Person
    {
        private string Name { get; set }
        private int Age { get; set }

        private Person (string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
}
