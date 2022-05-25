using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyGame.Models;

namespace MyGame.View
{
    class ViewEnemy
    {
        public static void EnemyAnimation(object sender, Graphics g, Enemy enemy)
        {
            if (enemy.currentFrame < enemy.currentImageLimit - 1)
                enemy.currentFrame += 1;
            else enemy.currentFrame = 0;
            if (enemy.characterDied)
                enemy.currentFrame = enemy.currentImageLimit - 1;
            g.DrawImage(enemy.spriteSheet, new Rectangle(new Point(enemy.positionX - enemy.direction * enemy.size, enemy.positionY),
                    new Size(enemy.direction * enemy.size * 2, enemy.size * 2)), 32 * enemy.currentFrame, 1 + 32 * enemy.currentAnimation,
                enemy.size, enemy.size, GraphicsUnit.Pixel);
        }
    }
}
