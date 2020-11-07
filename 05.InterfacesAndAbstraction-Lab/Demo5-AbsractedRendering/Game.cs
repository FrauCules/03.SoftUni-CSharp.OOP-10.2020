using Demo5_AbsractedRendering.Contracts;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Demo5_AbsractedRendering
{
    public class Game
    {
        private List<IGameObject> objects;
        private IDrawer drawer;

        public Game(IDrawer drawer)
        {
            this.drawer = drawer;
            objects = new List<IGameObject>();
            objects.Add(new Snake());
            objects.Add(new Food());
            objects.Add(new Obstacle());
            objects.Add(new Obstacle());
        }

        public void Start()
        {
            while (true)
            {
                Thread.Sleep(1000); // всяка секунда има ход в играта
                foreach (IGameObject item in objects) // след всеки ход чертаем (условно)
                {
                    item.Draw(this.drawer);
                }
            }
        }
    }
}
