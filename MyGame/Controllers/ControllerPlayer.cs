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
                    if (player.CharacterDied)
                        break;
                    if (PhysicsController.InConflictStairsUp(player.PositionX, player.PositionY))
                    {
                        player.ChangeY = 0;
                        player.IsMoving = false;
                        player.ChangeAnimation(0);
                    }
                    else
                    {
                        player.ChangeY = -2;
                        player.IsMoving = true;
                        player.ChangeAnimation(1);
                    }
                    break;
                case Keys.S:
                    if (player.CharacterDied)
                        break;
                    if (PhysicsController.InConflictStairsDown(player.PositionX, player.PositionY))
                    {
                        player.ChangeY = 0;
                        player.IsMoving = false;
                        player.ChangeAnimation(0);
                    }
                    else
                    {
                        player.ChangeY = 2;
                        player.IsMoving = true;
                        player.ChangeAnimation(1);
                    }
                    break;
                case Keys.D:
                    if (player.CharacterDied)
                        break;
                    player.Direction = 1;
                    if (PhysicsController.InConflictLeftAndRight(player.PositionX, player.PositionY, player.Direction))
                    {
                        player.IsMoving = false;
                        player.ChangeAnimation(0);
                    }
                    else
                    {
                        player.ChangeX = 5;
                        player.IsMoving = true;
                        player.ChangeAnimation(1);
                    }
                    break;
                case Keys.A:
                    if (player.CharacterDied)
                        break;
                    player.Direction = -1;
                    if (PhysicsController.InConflictLeftAndRight(player.PositionX, player.PositionY, player.Direction))
                    {

                        player.IsMoving = false;
                        player.ChangeAnimation(0);
                    }
                    else
                    {
                        player.ChangeX = -5;
                        player.IsMoving = true;
                        player.ChangeAnimation(1);
                    }
                    break;
                case Keys.Q:
                    if (player.CharacterDied)
                        break;
                    player.Direction = -1;
                    player.ChangeAnimation(0);
                    player.IsJump = true;
                    break;
                case Keys.E:
                    if (player.CharacterDied)
                        break;
                    player.Direction = 1;
                    player.ChangeAnimation(0);
                    player.IsJump = true;
                    player.JumpLevel = 0;
                    break;
                case Keys.R:
                    if (player.Weapon.CartridgesCount > 0 && player.Weapon.NumberCartridgesChamber < 6)
                    {
                        player.Weapon.NumberCartridgesChamber++;
                        player.Weapon.CartridgesCount--;
                        player.ChangeX = 0;
                        player.ChangeY = 0;
                        player.IsAttackGun = false;
                        player.IsMoving = false;
                        player.ChangeAnimation(0);
                    }
                    break;
                case Keys.Space:
                    if (player.CharacterDied)
                        break;
                    player.IsMoving = false;
                    player.IsAttackGun = player.Weapon.NumberCartridgesChamber > 0;
                    player.ChangeAnimation(player.IsAttackGun ? 5 : 0);
                    break;
                case Keys.Enter:
                    PhysicsController.CheckVictoryGame(player);
                    break;
            }
        }

        public void OnKeyUp(object sender, KeyEventArgs e)
        {
            player.ChangeX = 0;
            player.ChangeY = 0;
            player.IsMoving = false;
            player.IsJump = false;
            player.IsAttackGun = false;
            player.JumpLevel = 0;
            player.ChangeAnimation(player.CharacterDied ? 10 : 0);
        }
    }
}
