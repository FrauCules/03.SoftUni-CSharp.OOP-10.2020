using Demo5_AbsractedRendering.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo5_AbsractedRendering
{
    class Snake : IGameObject
    {
        public void Draw(IDrawer drawer)
        {
            drawer.WriteLine("Аз съм змията");
        }
    }
}
