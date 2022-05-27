using System.Drawing;
using MyGame.Models;

namespace MyGame.View
{
    class ViewEnemy
    {
        public static void EnemyAnimation(object sender, Graphics g, Enemy enemy)
        {
            if (enemy.CurrentFrame < enemy.CurrentImageLimit - 1)
                enemy.CurrentFrame += 1;
            else enemy.CurrentFrame = 0;
            if (enemy.characterDied)
                enemy.CurrentFrame = 10;
            g.DrawImage(enemy.SpriteSheet, new Rectangle(new Point(enemy.PositionX - enemy.Direction * enemy.Size, enemy.PositionY),
                    new Size(enemy.Direction * enemy.Size * 2, enemy.Size * 2)), 32 * enemy.CurrentFrame, 1 + 32 * enemy.CurrentAnimation,
                enemy.Size, enemy.Size, GraphicsUnit.Pixel);
        }
    }
}
