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
        public int PosX;
        public int PosY;

        public int idleFrames;
        public int runFrames;
        public int attackFrames;
        public int deathFrames;

        public int size;

        public Image spriteSheet;

        public Entity(int PosX, int PosY, int idleFrames, int runFrames, int attackFrames, int deathFrames, Image spriteSheet)
        {
            this.PosX = PosX;
            this.PosY = PosY;
            this.idleFrames = idleFrames;
            this.runFrames = runFrames;
            this.attackFrames = attackFrames;
            this.deathFrames = deathFrames;
            this.spriteSheet = spriteSheet;
            size = 31;
        }

        public void Move(int dirX, int dirY)
        {
            PosX += dirX;
            PosY += dirY;
        }
    }
}
