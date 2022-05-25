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
                    if (GameControllers.InConflictStairsUp(player.positionX, player.positionY))
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
                    if (GameControllers.InConflictStairsDown(player.positionX, player.positionY))
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
                    player.direction = 1;
                    if (GameControllers.InConflictLeftAndRight(player.positionX, player.positionY, player.direction))
                    {
                        player.changeX = 0;
                        player.isMoving = false;
                        player.ChangeAnimation(0);
                    }
                    else
                    {
                        player.changeX = 4;
                        player.isMoving = true;
                        player.ChangeAnimation(1);
                    }
                    break;
                case Keys.A:
                    player.direction = -1;
                    if (GameControllers.InConflictLeftAndRight(player.positionX, player.positionY, player.direction))
                    {
                        player.changeX = 0;
                        player.isMoving = false;
                        player.ChangeAnimation(0);
                    }
                    else
                    {
                        player.changeX = -4;
                        player.isMoving = true;
                        player.ChangeAnimation(1);
                    }
                    break;
                case Keys.Q:
                    player.changeX = -5;
                    player.changeY = -5;
                    player.isJump = true;
                    player.direction = -1;
                    player.jumpLevel = 0;
                    player.ChangeAnimation(0);
                    break;
                case Keys.Enter:
                    player.changeX = 0;
                    player.changeY = 0;
                    player.isMoving = false;
                    player.ChangeAnimation(5);
                    player.attackPower += 1;
                    break;
            }
        }

        public void OnKeyUp(object sender, KeyEventArgs e)
        {
            player.changeX = 0;
            player.changeY = 0;
            player.isMoving = false;
            player.isJump = false;
            player.ChangeAnimation(0);
        }
    }
}
