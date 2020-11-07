using System;
using System.Collections.Generic;
using System.Text;

namespace Demo5_AbsractedRendering.Contracts
{
    public interface IDrawer
    {
        void Write(string input);
        void WriteLine(string input);
    }
}
