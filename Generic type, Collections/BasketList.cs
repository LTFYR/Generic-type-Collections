using System;
using System.Collections.Generic;
using System.Text;

namespace Generic_type__Collections
{
     class BasketList<T>
    {
        private T[] arr;        
        public int Count
        {
            get { return arr.Length; }
        }
        public BasketList()
        {
            arr = new T[0];
        }
        public void Add(T item)
        {
            Array.Resize(ref arr,arr.Length + 1);
            arr[arr.Length - 1] = item;
        }
        public T[] GetVitArr()
        {
            return arr;
        }
    }
}
