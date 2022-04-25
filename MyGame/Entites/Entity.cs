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

        public int idleFrames;
        public int runFrames;
        public int attackFrames;
        public int deathFrames;

        public int size;

        public Image spriteSheet;

        public Entity(int posX, int posY, int idleFrames, int runFrames, int attackFrames, int deathFrames, Image spriteSheet)
        {
            this.posX = posX;
            this.posY = posY;
            this.idleFrames = idleFrames;
            this.runFrames = runFrames;
            this.attackFrames = attackFrames;
            this.deathFrames = deathFrames;
            this.spriteSheet = spriteSheet;
            size = 30;
        }
    }
}
