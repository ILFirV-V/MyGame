using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyGame.Models;

namespace MyGame.Controllers
{
    class PhysicsControllerPlayer
    {
        private readonly Player player;
        public PhysicsControllerPlayer(Player player)
        {
            this.player = player;
        }
        public void ReactionAir()
        {
            while (Map.getMapPieceType(player.positionX, player.positionY) == 1)
            {
                player.changeY = 2;
            }
        }
    }
}
