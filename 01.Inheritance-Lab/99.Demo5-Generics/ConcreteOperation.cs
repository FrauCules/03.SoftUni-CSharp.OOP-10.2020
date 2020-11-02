using System;
using System.Collections.Generic;
using System.Text;

namespace _99.Demo5_Generics
{
    class ConcreteOperation<T> : Operation
    {
        public T Name { get; set; }
    }
}
