using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleOfTanks
{
    class Program
    {
        static void Main(string[] args)
        {
            const int COUNT_OF_TANKS = 5;
            const string FIRST_TANK = "T-34";
            const string SECOND_TANK = "Pantera";
            int weapon;
            int armourLevel;
            int manoeuvrability;

            Random rnd = new Random();
            Tank[] t34 = new Tank[COUNT_OF_TANKS];
            Tank[] pantera = new Tank[COUNT_OF_TANKS];

            for (int i = 0; i < COUNT_OF_TANKS; i++)
            {
                weapon = rnd.Next(100);
                armourLevel = rnd.Next(100);
                manoeuvrability = rnd.Next(100);
                t34[i] = new Tank(FIRST_TANK, weapon, armourLevel, manoeuvrability);

                weapon = rnd.Next(100);
                armourLevel = rnd.Next(100);
                manoeuvrability = rnd.Next(100);
                pantera[i] = new Tank(SECOND_TANK, weapon, armourLevel, manoeuvrability);
            }
        }
    }
}
