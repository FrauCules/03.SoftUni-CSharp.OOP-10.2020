using Demo5_AbsractedRendering.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Demo5_AbsractedRendering
{
    class Food :IGameObject
    {
        public int IsEaten { get; set; }
       
        public void Draw(IDrawer drawer)
        {
            drawer.WriteLine("Вкусна храна");
        }
    }
}
