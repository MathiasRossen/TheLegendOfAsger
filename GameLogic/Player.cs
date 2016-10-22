using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLogic 
{
   
    public class Player : ICreature
    {
        int attack = 1;
        int hp = 1;
        int xp = 0;
        string name = "Asger";
        int skillPoint = 1;
        int maxHp = 1;

        public int Attack
        {
            get
            {
                return attack;
            }
            set
            {
                attack = value;
            }
        }

        public int Hp
        {
            get
            {
                return hp;
            }

            set
            {
                hp = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }
        }

        public int Xp
        {
            get
            {
                return xp;
            }

            set
            {
                xp = value;
            }
        }

        public int SkillPoint
        {
            get
            {
                return skillPoint;
            }
            set
            {
                skillPoint = value;
            }
            
        }

        public int MaxHp
        {
            get
            {
                return maxHp;
            }
            set
            {
                maxHp = value;
            }
        }

        public void IncreaseSkillHpByOne()
        {
            maxHp++;
            skillPoint--;
        }

        public void IncreaseSkillAttackByOne()
        {
            attack++;
            skillPoint--;
        }
    }
}
