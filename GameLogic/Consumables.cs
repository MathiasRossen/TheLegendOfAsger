using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLogic
{
    class Consumables : IItem
    {
        string name;
        int value;

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public int Value
        {
            get
            {
               return value;
            }

            set
            {
                this.value = value;
            }
        }

        public void Use(ICreature target)
        {
            target.Hp = target.MaxHp; 
        }
    }
}
