using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGame.Models
{
    class Weapon
    {
        public int damage;
        public int cartridgesCount;
        public int numberCartridgesChamber;

        public Weapon(int damage, int cartridgesCount)
        {
            this.damage = damage;
            this.cartridgesCount = cartridgesCount;
            numberCartridgesChamber = 6;
        }
    }
}
