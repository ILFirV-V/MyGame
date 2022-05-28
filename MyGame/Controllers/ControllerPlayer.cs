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
        private readonly Player Player;
        public ControllerPlayer(Player player)
        {
            Player = player;
        }

        public void OnPress(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W:
                    if (Player.CharacterDied)
                        break;
                    if (PhysicsController.InConflictStairsUp(Player.PositionX, Player.PositionY))
                    {
                        Player.ChangeY = 0;
                        Player.IsMoving = false;
                        Player.ChangeAnimation(0);
                    }
                    else
                    {
                        Player.ChangeY = -2;
                        Player.IsMoving = true;
                        Player.ChangeAnimation(1);
                    }
                    break;
                case Keys.S:
                    if (Player.CharacterDied)
                        break;
                    if (PhysicsController.InConflictStairsDown(Player.PositionX, Player.PositionY))
                    {
                        Player.ChangeY = 0;
                        Player.IsMoving = false;
                        Player.ChangeAnimation(0);
                    }
                    else
                    {
                        Player.ChangeY = 2;
                        Player.IsMoving = true;
                        Player.ChangeAnimation(1);
                    }
                    break;
                case Keys.D:
                    if (Player.CharacterDied)
                        break;
                    Player.Direction = 1;
                    if (PhysicsController.InConflictLeftAndRight(Player.PositionX, Player.PositionY, Player.Direction))
                    {
                        Player.IsMoving = false;
                        Player.ChangeAnimation(0);
                    }
                    else
                    {
                        Player.ChangeX = 5;
                        Player.IsMoving = true;
                        Player.ChangeAnimation(1);
                    }
                    break;
                case Keys.A:
                    if (Player.CharacterDied)
                        break;
                    Player.Direction = -1;
                    if (PhysicsController.InConflictLeftAndRight(Player.PositionX, Player.PositionY, Player.Direction))
                    {

                        Player.IsMoving = false;
                        Player.ChangeAnimation(0);
                    }
                    else
                    {
                        Player.ChangeX = -5;
                        Player.IsMoving = true;
                        Player.ChangeAnimation(1);
                    }
                    break;
                case Keys.R:
                    if (Player.Weapon.CartridgesCount > 0 && Player.Weapon.NumberCartridgesChamber < 6)
                    {
                        Player.Weapon.NumberCartridgesChamber++;
                        Player.Weapon.CartridgesCount--;
                        Player.ChangeX = 0;
                        Player.ChangeY = 0;
                        Player.IsAttackGun = false;
                        Player.IsMoving = false;
                        Player.ChangeAnimation(0);
                    }
                    break;
                case Keys.Space:
                    if (Player.CharacterDied)
                        break;
                    Player.IsMoving = false;
                    Player.IsAttackGun = Player.Weapon.NumberCartridgesChamber > 0;
                    Player.ChangeAnimation(Player.IsAttackGun ? 5 : 0);
                    break;
                case Keys.Enter:
                    PhysicsController.CheckVictoryGame(Player);
                    break;
            }
        }

        public void OnKeyUp(object sender, KeyEventArgs e)
        {
            Player.ChangeX = 0;
            Player.ChangeY = 0;
            Player.IsMoving = false;
            Player.IsAttackGun = false;
            Player.ChangeAnimation(Player.CharacterDied ? 10 : 0);
        }
    }
}
