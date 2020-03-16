using System;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {

            ArrayLists();

            var list = new List<int>();
            var list2 = new List<string>();

            var sortedlist = new SortedSequence<string>();
            sortedlist.Add("asdf");
            sortedlist.Add("as");
            sortedlist.Add("as");
            for (int i = 0; i )
        }

        private static void ArrayLists()
        {
            var arraylist = new ArrayList();

            arraylist.Add(1);
            arraylist.Add(2);
            arraylist.Add(3);
            arraylist.Add(new ArrayList());
            arraylist.Add("asdf");

            //
            //
            foreach(int num in arraylist)
            {
                Console.Write
            }
        }
    }
}
