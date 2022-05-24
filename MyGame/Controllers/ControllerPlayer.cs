using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyGame.Models;

namespace MyGame.Controllers
{
    class ControllerPlayer
    {
        private readonly Player player;
        public ControllerPlayer(Player player)
        {
            this.player = player;
        }

        public void OnPress(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W:
                    if (player.InConflictStairsUp(player.positionX, player.positionY))
                    {
                        player.changeY = 0;
                        player.isMoving = false;
                        player.ChangeAnimation(0);
                    }
                    else
                    {
                        player.changeY = -2;
                        player.isMoving = true;
                        player.ChangeAnimation(1);
                    }
                    break;
                case Keys.S:
                    if (player.InConflictStairsDown(player.positionX, player.positionY))
                    {
                        player.changeY = 0;
                        player.isMoving = false;
                        player.ChangeAnimation(0);
                    }
                    else
                    {
                        player.changeY = 2;
                        player.isMoving = true;
                        player.ChangeAnimation(1);
                    }
                    break;
                case Keys.D:
                    player.changeX = 6;
                    player.isMoving = true;
                    player.direction = 1;
                    player.ChangeAnimation(1);
                    break;
                case Keys.A:
                    player.changeX = -6;
                    player.isMoving = true;
                    player.direction = -1;
                    player.ChangeAnimation(1);
                    break;
                case Keys.Space:
                    player.changeX = 0;
                    player.changeY = 0;
                    player.isMoving = false;
                    player.ChangeAnimation(5);
                    break;
            }
        }

        public void OnKeyUp(object sender, KeyEventArgs e)
        {
            player.changeX = 0;
            player.changeY = 0;
            player.isMoving = false;
            player.ChangeAnimation(0);
        }
    }
}
