using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
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
                    if (player.characterDied)
                        break;
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
                    if (player.characterDied)
                        break;
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
                    if (player.characterDied)
                        break;
                    player.direction = 1;
                    if (GameControllers.InConflictLeftAndRight(player.positionX, player.positionY, player.direction))
                    {
                        player.changeX = 0;
                        player.isMoving = false;
                        player.ChangeAnimation(0);
                    }
                    else
                    {
                        player.changeX = 5;
                        player.isMoving = true;
                        player.ChangeAnimation(1);
                    }
                    break;
                case Keys.A:
                    if (player.characterDied)
                        break;
                    player.direction = -1;
                    if (GameControllers.InConflictLeftAndRight(player.positionX, player.positionY, player.direction))
                    {
                        player.changeX = 0;
                        player.isMoving = false;
                        player.ChangeAnimation(0);
                    }
                    else
                    {
                        player.changeX = -5;
                        player.isMoving = true;
                        player.ChangeAnimation(1);
                    }
                    break;
                case Keys.Q:
                    if (player.characterDied)
                        break;
                    player.direction = -1;
                    player.ChangeAnimation(0);
                    player.isJump = true;
                    break;
                case Keys.E:
                    if (player.characterDied)
                        break;
                    player.direction = 1;
                    player.ChangeAnimation(0);
                    player.isJump = true;
                    break;
                case Keys.Enter:
                    if (player.characterDied)
                        break;
                    player.isAttack = player.weapon.cartridgesCount > 0;
                    player.ChangeAnimation(player.isAttack ? 5 : 0);
                    break;
            }
        }

        public void OnKeyUp(object sender, KeyEventArgs e)
        {
            player.changeX = 0;
            player.changeY = 0;
            player.isMoving = false;
            player.isJump = false;
            player.isAttack = false;
            player.ChangeAnimation(player.characterDied ? 10 : 0);
        }
    }
}
