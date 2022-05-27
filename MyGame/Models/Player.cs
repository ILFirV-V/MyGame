using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyGame.Controllers;

namespace MyGame.Models
{
    public class Player
    {
        public int Size;
        public Image SpriteSheet;

        public int PositionX;
        public int PositionY;
        public int ChangeX;
        public int ChangeY;

        public int Direction;

        public bool IsMoving;
        public bool IsJump;
        public bool IsAttackGun;
        public bool IsHaveKey;

        public int CurrentAnimation;
        public int CurrentImageLimit;
        public int CurrentFrame;
        public int IdleFrames;
        public int RunFrames;
        public int AttackFrames;
        public int DeathFrames;

        public int DiamondsCount;
        public int XP;
        public int AttackPower;
        public int JumpLevel = -1;

        public bool CharacterDied;
        public Weapon Weapon;

        public int Diamonds;
        public List<(int, int)> CollectedDiamonds;
        public List<(int, int)> CollectedCartridges;

        public Player(int posX, int posY, Image spriteSheet, int size, int idleFrames, int runFrames, int attackFrames,
            int deathFrames)
        {
            PositionX = posX;
            PositionY = posY;
            Direction = 1;
            Size = size;
            SpriteSheet = spriteSheet;
            IdleFrames = idleFrames;
            RunFrames = runFrames;
            AttackFrames = attackFrames;
            DeathFrames = deathFrames;

            CurrentFrame = 0;
            DiamondsCount = 0;
            XP = 250;
            AttackPower = 0;
            Weapon = new Weapon(5, 100);
            CollectedDiamonds = new List<(int, int)>();
            CollectedCartridges = new List<(int, int)>();
        }

        public void ChangeAnimation(int currentAnimation)
        {
            CurrentAnimation = currentAnimation;
            switch (currentAnimation)
            {
                case 0:
                    CurrentImageLimit = IdleFrames;
                    break;
                case 1:
                    CurrentImageLimit = RunFrames;
                    break;
                case 5:
                    CurrentImageLimit = AttackFrames;
                    break;
                case 6:
                    CurrentImageLimit = DeathFrames;
                    break;
            }
        }

        public void StateOnMap()
        {
            if (XP <= 0)
            {
                ChangeAnimation(6);
                CharacterDied = true;
                IsMoving = false;
                IsJump = false;
                IsAttackGun = false;
            }
        }

        public void Move()
        {
            Fall();
            if (IsMoving && !CharacterDied)
            {
                PositionX += ChangeX;
                PositionY += ChangeY;
            }
        }

        public void Attack()
        {
            if (IsAttackGun)
            {
                Weapon.NumberCartridgesChamber--;
                IsAttackGun = false;
            }
        }

        public void Fall()
        {
            if (PhysicsController.EssenceInAir(PositionX, PositionY) && !IsJump)
            {
                IsMoving = false;
                PositionY += 4;
            }
        }

        public void CollectThings()
        {
            var changedPositionY = (int) Math.Ceiling((PositionY + 25) / 30.0);
            var changedPositionX = (int) Math.Floor(PositionX / 30.0);
            if (Map.getMapPieceType(changedPositionX, changedPositionY) == 9 
                && !(CollectedDiamonds.Contains((changedPositionX, changedPositionY)) && CollectedDiamonds != null))
            {
                CollectedDiamonds.Add((changedPositionX, changedPositionY));
                Diamonds++;
            }
            if (Map.getMapPieceType(changedPositionX, changedPositionY) == 17
                && !(CollectedCartridges.Contains((changedPositionX, changedPositionY)) && CollectedCartridges != null))
            {
                CollectedCartridges.Add((changedPositionX, changedPositionY));
                Weapon.CartridgesCount += 25;
            }
            if (Map.getMapPieceType(changedPositionX, changedPositionY) == 16)
            {
                IsHaveKey = true;
            }
        }

        public void CheckVictoryGame()
        {
            var changedPositionY = (int)Math.Ceiling((PositionY + 25) / 30.0);
            var changedPositionX = (int)Math.Floor(PositionX / 30.0);
            if (Map.getMapPieceType(changedPositionX, changedPositionY) == 10 && IsHaveKey)
            {
                PhysicsController.VictoryGame = true;
            }
        }
    }
}
