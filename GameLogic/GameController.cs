using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLogic
{
    public enum BattleOutcome { Win, Draw, Lose };

    public class GameController
    {

        public BattleOutcome CheckForWinner(ICreature creatureOne, ICreature creatureTwo)
        {
            if (creatureOne.Attack >= creatureTwo.Hp && creatureTwo.Attack >= creatureOne.Hp)
            {
                return BattleOutcome.Draw;
            }
            else if (creatureOne.Attack >= creatureTwo.Hp)
            {
                return BattleOutcome.Win;
            }
            else
                return BattleOutcome.Lose;
        }
    }


}
