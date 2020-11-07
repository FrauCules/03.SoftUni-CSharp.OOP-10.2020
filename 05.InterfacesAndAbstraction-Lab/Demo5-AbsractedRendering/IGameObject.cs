using Demo5_AbsractedRendering.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo5_AbsractedRendering
{
    interface IGameObject
    {
        void Draw(IDrawer drawer);
    }
}
