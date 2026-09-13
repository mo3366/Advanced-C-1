using System;
using System.Collections.Generic;
using System.Text;

namespace Advanced_C__1.generic_class
{
    internal class Container<T>
    {
        private List<T> _items = new List<T>();
        public void Add(T item)
        {
            _items.Add(item);
        }
        public T Get(int index)
        {
            return _items[index];
        }
    }
}
