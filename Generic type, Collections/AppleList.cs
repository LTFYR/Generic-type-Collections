using System;
using System.Collections.Generic;
using System.Text;

namespace Generic_type__Collections
{
    class AppleList
    {
        private Apple[] arr;
        public int Count
        {
            get { return arr.Length; }
        }
        public AppleList()
        {
            arr = new Apple[0];
        }
        public void Add(Apple fruit)
        {
            Array.Resize(ref arr, arr.Length + 1);
            arr[arr.Length - 1] = fruit;
        }
        public Apple[] GetVitArr()
        {
            return arr;
        }
    }
}
