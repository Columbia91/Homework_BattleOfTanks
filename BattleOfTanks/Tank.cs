using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleOfTanks
{
    class Tank
    {
        public string Name { get; set; }
        public int Weapon { get; set; }
        public int ArmourLevel { get; set; }
        public int Manoeuvrability { get; set; }

        #region Конструкторы
        public Tank() { }
        public Tank(string name, int weapon, int armourLevel, int manoeuvrability)
        {
            Name = name;
            Weapon = weapon; ArmourLevel = armourLevel; Manoeuvrability = manoeuvrability;
        }
        #endregion
    }
}
