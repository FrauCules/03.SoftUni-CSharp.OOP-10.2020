using System;
using System.Collections.Generic;
using System.Text;

namespace Demo_Game
{
    public class Player
    {
        public Player(string name)
        {
            Name = name;
        }

        public string Name { get; set; }

        public override string ToString()
        {
            return $"{Name}";
        }
    }
}
