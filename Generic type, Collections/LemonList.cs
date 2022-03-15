using System;
using System.Collections.Generic;
using System.Text;

namespace Generic_type__Collections
{
    class LemonList 
    {
        private Lemon[] arr;
        public int Count
        {
            get { return arr.Length; }
        }
        public LemonList()
        {
            arr = new Lemon[0];
        }
        public void Add(Lemon vitamin)
        {
            Array.Resize(ref arr, arr.Length + 1);
            arr[arr.Length - 1] = vitamin;
        }
        public Lemon[] GetVitArr()
        {
            return arr;
        }
    }
}
