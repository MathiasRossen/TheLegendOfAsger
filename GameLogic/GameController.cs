using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLogic
{
    public enum BattleOutcome { Win, Draw, Lose, None };
    public enum WeekDays { Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday};

    public class GameController
    {
        public static WeekDays CurrentDay = WeekDays.Monday;

        public BattleOutcome CheckForWinner(Player player, ICreature enemy)
        {
            player.Hp -= enemy.Attack;
            enemy.Hp -= player.Attack;

            if (player.Hp <= 0 && enemy.Hp <= 0 )
            {
                CurrentDay++;
                return BattleOutcome.Draw;
            }
            else if (player.Hp > 0 && enemy.Hp <= 0)
            {
                player.SkillPoint += enemy.SkillPoint;
                CurrentDay++;
                return BattleOutcome.Win;
            }
            else if (enemy.Hp > 0 && player.Hp <= 0)
            {
                CurrentDay++;
                return BattleOutcome.Lose;
            }

            return BattleOutcome.None;

        }

        public static void PassDay()
        {
            if (CurrentDay == WeekDays.Sunday)
            {
                CurrentDay = WeekDays.Monday;
            }
            else CurrentDay++;
        }


    }


}
