using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLogic
{
    public enum outcome { Win, Draw, Lose };

    public class GameLogic
    {

        public outcome CheckForWinner(ICreature creatureOne, ICreature creatureTwo)
        {
            if (creatureOne.Attack >= creatureTwo.Hp)
            {
                return outcome.Win;
            }
            else if (creatureOne.Attack >= creatureTwo.Hp && creatureTwo.Attack >= creatureOne.Hp)
            {
                return outcome.Draw;
            }
            else
                return outcome.Lose;
        }
    }
}
