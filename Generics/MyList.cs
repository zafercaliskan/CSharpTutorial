using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Generics
{
    public class MyList<T>
    {
        private T[] _items;

        public MyList()
        {
            _items = new T[0];
        }

        public void Add(T item)
        {
            T[] tempArray = _items;

            _items = new T[_items.Length + 1];

            for (int i = 0; i < tempArray.Length; i++)
            {
                _items[i] = tempArray[i];
            }

            _items[_items.Length - 1] = item;
        }

        public int Length
        {
            get
            {
                return _items.Length;
            }
        }

        public T[] items
        {
            get
            {
                return _items;
            }
        }
    }
}
