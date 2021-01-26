using System;
using System.Collections.Generic;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            var myDictionary = new MyDictionary<int, string>();
            myDictionary.Add(101, "Zafer Çalışkan");
            myDictionary.Add(102, "Süleyman Çalışkan");

            Console.WriteLine($"Key: {myDictionary["Zafer Çalışkan"]} Value: {myDictionary[101]}");
            Console.WriteLine($"Key: {myDictionary["Süleyman Çalışkan"]} Value: {myDictionary[102]}");
        }
    }

    class MyDictionary<TKey, TValue>
    {
        private List<TKey> _keys;
        private List<TValue> _values;
        public MyDictionary()
        {
            _keys = new List<TKey>();
            _values = new List<TValue>();
        }

        public TValue this[TKey key]
        {
            //Burada gönderdiğimiz key ile _keys içerisindeki index'ini buluyoruz. 
            //Dictionary yapısı gereği _keys'in index'i _values'un index'i ile aynıdır.
            get { return _values[_keys.IndexOf(key)]; }
        }

        public TKey this[TValue value]
        {
            get { return _keys[_values.IndexOf(value)]; }
        }
        public void Add(TKey key, TValue value)
        {
            _keys.Add(key);
            _values.Add(value);
        }
    }
}