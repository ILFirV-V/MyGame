using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyGame.Models
{
    class Enemy
    {
        private readonly Player player;
        public int positionX;
        public int positionY;

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

        public int life;

        public Enemy(int posX, int posY, Image spriteSheet, int size, int idleFrames, int runFrames, int attackFrames,
            int deathFrames, Player player, int life)
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
            this.player = player;
            this.life = life;
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
            direction = player.positionX < positionX ? -1 : 1;
            if (IsSeePlayer(player.positionY))
            {
                isMoving = true;
                changeAnimation(1);
                positionX += direction * 2;
            }
            else
            {
                isMoving = false;
                changeAnimation(0);
            }
        }

        public void Fall()
        {
            if (IsAir())
            {
                positionY += 2;
                isMoving = false;
            }
            else
            {
                isMoving = true;
            }
        }

        public bool IsSeePlayer(int positionPlayerY)
        {
            var posY = positionY - 16;
            for (var i = 1; i <= 32; i++)
            {
                if (positionPlayerY == posY + i)
                {
                    isMoving = true;
                    return true;
                }
            }
            return false;
        }

        public bool IsAir()
        {
            var changedPositionY = (int)Math.Ceiling(positionY / 30.0);
            if (Map.getMapPieceType(positionX / 30, changedPositionY + 1) == 1)
                return true;
            return false;
        }
    }
}