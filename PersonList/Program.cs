using System;
using

namespace PersonList
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person("Brad", 21);
            Person person2 = new Person("Britney", 22);
            Person person3 = new Person("Barney", 23);
            Person person4 = new Person("Bernard", 24);
            Person person5 = new Person("Bailey", 25);

            var peopleList = new Lists<string> (); 
            peopleList.Add(person1);
            peopleList.Add(person2);
            peopleList.Add(person3);
            peopleList.Add(person4);
            peopleList.Add(person5);
        }
    }
}
