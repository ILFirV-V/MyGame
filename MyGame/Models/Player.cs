using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGame.Models
{
    class Player
    {
        public int positionX;
        public int positionY;
        public int changeX;
        public int changeY;

        public int direction;

        public bool isMoving;

        public int size;
        public Image spriteSheet;

        public int currentAnimation;
        public int currentImageLimit;
        public int currentFrame;
        public int idleFrames;
        public int runFrames;
        public int attackFrames;
        public int deathFrames;


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
        }

        public void Move()
        {
            positionX += changeX;
            positionY += changeY;
        }

        public void changeAnimation(int currentAnimation)
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
    }
}
