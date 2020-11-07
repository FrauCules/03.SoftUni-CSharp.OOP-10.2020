using _99.Demo1_Interface_good_code.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace _99.Demo1_Interface_good_code
{
    class Shoe : IPrice
    {
        public decimal Price { get; set; }
        public string Model  { get; set; }
        public int Size { get; set; }

    }
}
