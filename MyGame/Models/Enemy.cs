using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGame.Models
{
    class Enemy
    {
        private readonly Player player;
        public Enemy(Player player)
        {
            this.player = player;
        }

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


        public Enemy(int posX, int posY, Image spriteSheet, int size, int idleFrames, int runFrames, int attackFrames,
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
                case 3:
                    currentImageLimit = attackFrames;
                    break;
                case 9:
                    currentImageLimit = deathFrames;
                    break;
            }
        }

        public void Move()
        {
            if (IsSeePlayer(player.positionY))
                positionY += changeY;
        }

        public bool IsSeePlayer(int positionPlayerY)
        {
            return positionY == positionPlayerY;
        }
    }
}