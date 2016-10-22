using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLogic
{
    public interface ICreature
    {
        int Attack
        {
            get;
            set;
        }

        int Hp
        {
            get;
            set;
        }

        string Name
        {
            get;
        }

        int SkillPoint
        {
            get;
        }
    }

}
