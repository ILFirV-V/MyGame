using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGame.Models
{
    public class Weapon
    {
        public int Damage;
        public int CartridgesCount;
        public int NumberCartridgesChamber;

        public Weapon(int damage, int cartridgesCount)
        {
            Damage = damage;
            CartridgesCount = cartridgesCount;
            NumberCartridgesChamber = 6;
        }
    }
}
