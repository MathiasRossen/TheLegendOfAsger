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
            player.Hp -= enemy.Attack;
            enemy.Hp -= player.Attack;

            if (player.Hp <= 0 && enemy.Hp <= 0 )
            {
                return BattleOutcome.Draw;
            }
            else if (player.Hp > 0 && enemy.Hp <= 0)
            {
                player.SkillPoint += enemy.SkillPoint;
                return BattleOutcome.Win;
            }
            else if (enemy.Hp > 0 && player.Hp <= 0)
            {
                return BattleOutcome.Lose;
            }

            return BattleOutcome.None;

        }

    }


}
