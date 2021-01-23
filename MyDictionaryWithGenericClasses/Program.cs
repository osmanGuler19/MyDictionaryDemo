using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            MyDictionary<int,string> myDictionary = new MyDictionary<int,string>();
            myDictionary.Add(1, "Osman");
            myDictionary.Add(2, "Pınar");
            myDictionary.Add(2, "Dilek");
            myDictionary.ListDictionary();
        }
    }


    class MyDictionary<K,V>
    {
        K[] _arrayK;
        V[] _arrayV;


        public MyDictionary()
        {
            _arrayK = new K[0];
            _arrayV = new V[0];
        }

        public void Add(K key, V value)
        {
            if(Array.IndexOf(_arrayK,key) > -1)
            {
                Console.WriteLine("Keys must be unique!");
                return;
            }
            K[] _temparrayK;
            _temparrayK = _arrayK;
            _arrayK = new K[_arrayK.Length + 1];
            for (int i = 0; i < _temparrayK.Length; i++)
            {
                _arrayK[i] = _temparrayK[i];
            }
            _arrayK[_arrayK.Length - 1] = key;

            V[] _temparrayV;
            _temparrayV = _arrayV;
            _arrayV = new V[_arrayV.Length + 1];
            for (int i = 0; i < _temparrayV.Length; i++)
            {
                _arrayV[i] = _temparrayV[i];
            }
            _arrayV[_arrayV.Length - 1] = value;
        }

        public void ListDictionary()
        {
            for (int i = 0; i < _arrayK.Length; i++)
            {
                Console.WriteLine("{ " + _arrayK[i] + " , " + _arrayV[i] + " }");
            }
        }
    }
}
