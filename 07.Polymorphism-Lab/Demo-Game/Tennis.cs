using System;
using System.Collections.Generic;
using System.Text;

namespace Demo_Game
{
    public class Tennis : TwoPlayerGame
    {
        public Tennis(Player playerOne, Player playerTwo)
            : base(playerOne, playerTwo)
        { }
        public override string GetDescription()
        {
            return $"{playerOne} broke his rachet,  {playerTwo} hot the judge";
        }
    }
}
