using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace _99.Demo6_CustomList
{
    public class BaseList<T> : IEnumerable<T>
    {
        private T[] array;
        private int index = 0;

        public BaseList()
        {
            array = new T[20];
        }
        public virtual void Add(T element)
        {
            array[index++]= element;
        }

        public T Get(int i)
        {
            return array[i];
        }

        public IEnumerator<T> GetEnumerator() // за да имаме foreach
        {
            for (int i = 0; i < index; i++)
            {
                yield return array[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
