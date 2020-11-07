using System;
using System.Collections.Generic;
using System.Text;

namespace _99.Demo2_Interface
{
    interface IManager : IWorker
    {
        public List<IWorker> Team { get; set; }
    }
}
