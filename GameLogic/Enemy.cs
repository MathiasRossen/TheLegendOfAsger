using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLogic
{
    public class Enemy : ICreature
    {

        int attack = 5;
        int hp = 5;
        string name = "Enemy";
        int skillPoint;
        int maxHp;
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

        public int SkillPoint
        {
            get
            {
                return skillPoint;
            }
        }
        public int MaxHp
        {
            get
            {
                return maxHp;
            }
        }

        public int Currency
        {
            get
            {
                return currency;
            }

        }

        // not a reff.
        public Enemy(string name, int hp, int attack, int skillPoint, int currency)
        {
            this.name = name;
            this.hp = hp;
            this.attack = attack;
            this.skillPoint = skillPoint;
            this.currency = currency;
            maxHp = hp;
        } 
    }
}
