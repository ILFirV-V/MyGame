using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGame.Entites
{
    public class Entity
    {
        public int posX;
        public int posY;
        public int dirX;
        public int dirY;
        public int flip;

        public bool isMoving;

        public int idleFrames;
        public int runFrames;
        public int attackFrames;
        public int deathFrames;
        public int currentFrame;
        public int currentAnimation;
        public int currentLimit;

        public int size;
        public Image spriteSheet;

        public Entity(int posX, int posY, int idleFrames, int runFrames, int attackFrames, int deathFrames, Image spriteSheet, int size)
        {
            this.posX = posX;
            this.posY = posY;
            this.idleFrames = idleFrames;
            this.runFrames = runFrames;
            this.attackFrames = attackFrames;
            this.deathFrames = deathFrames;
            this.spriteSheet = spriteSheet;
            this.size = size;
            currentFrame = 0;
            currentAnimation = 0;
            currentLimit = idleFrames;
            flip = 1;
        }

        public void Move()
        {
            posX += dirX;
            posY += dirY;
        }

        public void PlayAnimation(object sender, Graphics g)
        {
            if (currentFrame < currentLimit - 1)
                currentFrame += 2;
            else currentFrame = 0;
            g.DrawImage(spriteSheet, new Rectangle(new Point(posX - flip * size / 2, posY), new Size(flip * size * 2, size * 2)), 22 + 32 * currentFrame, 8 +  32 * currentAnimation, size, size, GraphicsUnit.Pixel);
        }

        public void SetAnimathilonConfiguration(int currentAnimation)
        {
            this.currentAnimation = currentAnimation;

            switch (currentAnimation)
            {
                case 0:
                    currentLimit = idleFrames;
                    break;
                case 1:
                    currentLimit = runFrames;
                    break;
                case 5:
                    currentLimit = attackFrames;
                    break;
                case 6:
                    currentLimit = deathFrames;
                    break;
            }
        }
    }
}
