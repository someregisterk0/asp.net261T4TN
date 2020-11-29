using System;
using System.Collections.Generic;
using System.Text;

namespace Generic01_sample
{
    class ArrayList<T>
    {
        T[] arr;
        int size = 0;
        int maxSize = 10;
       
        public ArrayList()
        {
            arr = new T[maxSize];
        }

        public void Add(T item)
        {
            arr[size++] = item;
        }

        public void PrintList()
        {
            foreach(T item in arr)
            {
                Console.WriteLine(item);
            }
        }
    }
}
