using System;
using System.Text;

namespace _99.Demo6_CustomList
{
    public class SoftUniList<T> : BaseList<T>
    {
        public override void Add(T item)
        {
            Console.WriteLine("Adding element: " + item);
            base.Add(item);
        }
    }
}
