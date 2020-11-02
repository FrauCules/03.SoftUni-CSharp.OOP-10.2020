using System;
using System.Collections.Generic;
using System.Text;

namespace CustomRandomList
{
    public class RandomList: List<string>
    {
        private Random random = new Random();

        public RandomList()
        {
            this.random = new Random();
        }

        public string RandomString()
        {
            int index = random.Next(0, this.Count);
            string remove = this[index]; // this[index] - така ползва вътр.индексатор
            this.RemoveAt(index);

            return remove;
        }
    }
}
