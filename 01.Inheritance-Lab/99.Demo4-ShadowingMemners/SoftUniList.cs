using System;
using System.Collections.Generic;
using System.Text;

namespace _99.Demo4_ShadowingMemners
{
    public class SoftUniList<T> : List<T>
    {
        public void Add(T item)
        {
            Console.WriteLine("Adding element: " + item);
            base.Add(item);
        }
    }
}
