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
        public bool isJump = false;

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

        public bool characterDied = false;

        public Player(int posX, int posY, Image spriteSheet, int size, int idleFrames, int runFrames, int attackFrames, int deathFrames)
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

        public void Jump()
        {
            if (isJump && jumpLevel == 0)
            {
                positionX += 5;
                positionY += 5;
                jumpLevel = 1;
            }
            else if (isJump && jumpLevel == 1)
            {
                positionX += 0;
                positionY += 0;
                jumpLevel = 2;
            }
            else if (isJump && jumpLevel == 2)
            {
                positionX -= 5;
                positionY -= 5;
                jumpLevel = 0;
            }
        }

        public void Fall()
        {
            if (GameControllers.EssenceInAir(positionX, positionY))
            {
                isMoving = false;
                positionY += 4;
            }
        }
    }
}
