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
            g.DrawImage(enemy.spriteSheet, new Rectangle(new Point(enemy.positionX - enemy.direction * enemy.size / 2, enemy.positionY), 
                new Size(enemy.direction * enemy.size * 2, enemy.size * 2)),enemy.currentFrame, 1 + enemy.currentAnimation, 
                enemy.size, enemy.size, GraphicsUnit.Pixel);
        }
    }
}
