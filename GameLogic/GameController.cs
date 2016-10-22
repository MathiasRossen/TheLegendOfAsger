using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLogic
{
    public enum BattleOutcome { Win, Draw, Lose, None };
    public class GameController
    {
        public BattleOutcome CheckForWinner(Player player, ICreature enemy)
        {
            if (player.Attack >= enemy.Hp && enemy.Attack >= player.Hp)
            {
                return BattleOutcome.Draw;
            }
            else if (player.Attack >= enemy.Hp)
            {
                player.SkillPoint += enemy.SkillPoint;
                return BattleOutcome.Win;
            }
            else
                return BattleOutcome.Lose;
        }

    }


}
