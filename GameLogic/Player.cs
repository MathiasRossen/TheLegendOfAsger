﻿namespace GameLogic 
{
   
    public class Player : ICreature
    {
        int attack = 1;
        int hp = 1;
        int xp = 0;
        string name = "Asger";
        int skillPoint = 1;
        int maxHp = 1;
        int currency;

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
                if (value <= maxHp)
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

        public int Currency
        {
            get
            {
                return currency;
            }

            set
            {
                currency = value;
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
