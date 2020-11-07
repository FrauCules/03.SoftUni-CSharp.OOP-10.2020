using Demo5_AbsractedRendering.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo5_AbsractedRendering.Drawers
{
    public class ConsoleDrawer : IDrawer
    {
        public void Write(string input)
        {
            Console.Write(input);
        }

        public void WriteLine(string input)
        {
            Console.WriteLine(input);
        }
    }
}
