using System;
using System.Collections.Generic;
using System.Text;

namespace Generic_type__Collections
{
    class PineAppleList
    {
        private Pineapple[] arr;
        public int Count
        {
            get { return arr.Length; }
        }
        public PineAppleList()
        {
            arr = new Pineapple[0];
        }
        public void Add(Pineapple vitamin)
        {
            Array.Resize(ref arr, arr.Length + 1);
            arr[arr.Length - 1] = vitamin;
        }
        public Pineapple[] GetVitArr()
        {
            return arr;
        }
    }
}
