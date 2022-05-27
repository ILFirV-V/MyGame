using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyGame.Controllers;

namespace MyGame.Models
{
    class Player
    {
        public int size;
        public Image spriteSheet;

        public int positionX;
        public int positionY;
        public int changeX;
        public int changeY;

        public int direction;

        public bool isMoving;
        public bool isJump;
        public bool isAttack;

        public int currentAnimation;
        public int currentImageLimit;
        public int currentFrame;
        public int idleFrames;
        public int runFrames;
        public int attackFrames;
        public int deathFrames;

        public int diamondsCount;
        public int XP;
        public int attackPower;
        public int jumpLevel = -1;
        public int diamonds;
        public int attackLevel = -1;

        public bool characterDied;
        public Weapon weapon;
        public List<(int, int)> collectedDiamonds;

        public Player(int posX, int posY, Image spriteSheet, int size, int idleFrames, int runFrames, int attackFrames,
            int deathFrames)
        {
            positionX = posX;
            positionY = posY;
            direction = 1;
            this.size = size;
            this.spriteSheet = spriteSheet;
            this.idleFrames = idleFrames;
            this.runFrames = runFrames;
            this.attackFrames = attackFrames;
            this.deathFrames = deathFrames;


            currentFrame = 0;
            diamondsCount = 0;
            XP = 250;
            attackPower = 0;
            weapon = new Weapon(2, 20);
            collectedDiamonds = new List<(int, int)>();
        }

        public void ChangeAnimation(int currentAnimation)
        {
            this.currentAnimation = currentAnimation;
            switch (currentAnimation)
            {
                case 0:
                    currentImageLimit = idleFrames;
                    break;
                case 1:
                    currentImageLimit = runFrames;
                    break;
                case 5:
                    currentImageLimit = attackFrames;
                    break;
                case 6:
                    currentImageLimit = deathFrames;
                    break;
            }
        }

        public void StateOnMap()
        {
            if (XP <= 0)
            {
                ChangeAnimation(6);
                characterDied = true;
                isMoving = false;
                isJump = false;
                isAttack = false;
            }
        }

        public void Move()
        {
            if (isMoving && !characterDied)
            {
                positionX += changeX;
                positionY += changeY;
            }

            Fall();
        }

        public void Jump1()
        {
            if (isJump && jumpLevel == 0)
            {
                positionX += direction * 20;
                positionY -= 20;
                jumpLevel = 1;
                isJump = false;
            }
        }

        public void Attack()
        {
            if (isAttack && weapon.cartridgesCount > 0)
            {
                isAttack = false;
                weapon.cartridgesCount--;
            }
        }

        public void Fall()
        {
            if (GameControllers.EssenceInAir(positionX, positionY) && !isJump)
            {
                isMoving = false;
                positionY += 4;
            }
        }

        public void isCollectsDiamond()
        {
            var changedPositionY = (int) Math.Ceiling((positionY + 25) / 30.0);
            var changedPositionX = (int) Math.Floor(positionX / 30.0);
            if (Map.getMapPieceType(changedPositionX, changedPositionY) == 9 && !(collectedDiamonds.Contains((changedPositionX, changedPositionY)) && collectedDiamonds != null))
                //&& GameControllers.getStatusDiamonds(changedPositionX, changedPositionY))
            {
                collectedDiamonds.Add((changedPositionX, changedPositionY));
                diamonds++;
                GameControllers.statusDiamonds[(changedPositionX, changedPositionY)] = true;
            }
        }
    }
}
