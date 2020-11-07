using Demo5_AbsractedRendering.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo5_AbsractedRendering
{
    class Obstacle : IGameObject
    {
        public void Draw(IDrawer drawer)
        {
            drawer.WriteLine("Препятствие на пътя");
        }
    }
}
