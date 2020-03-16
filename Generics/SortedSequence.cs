using System;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
    //behaves like a list, but keeps itself sorted
    // you declare a class type parameter with <(name)> right after the class name
    // after the "where" come type constraints
    // e.g. class, struct, any specific type
    class SortedSequence<T> : IEnumerable<T> where T : new()
    {
        List<T> list = new List<T>();

        public SortedSequence()
        {
            Add(default);
        }

        public void Add(T item)
        {
            _list.Add(item);
            _list.Sort();
        }
        //implement indexer operator []
        public T this[int i] 
        {
            get => _list[i];
            set => _list[i] = value;
        }
    }
}
