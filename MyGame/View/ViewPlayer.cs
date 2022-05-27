using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyGame.Models;

namespace MyGame.View
{
    class ViewPlayer
    {
        public static void PlayerAnimation(object sender, Graphics g, Player player)
        {
            if (player.currentFrame < player.currentImageLimit - 1)
                player.currentFrame += 2;
            else player.currentFrame = 0;
            if (player.characterDied)
                player.currentFrame = 4;
            g.DrawImage(player.spriteSheet, new Rectangle(new Point(player.positionX - player.direction * player.size / 2, player.positionY), 
                new Size(player.direction * player.size * 2, player.size * 2)), 20 + 32 * player.currentFrame, 3 + 32 * player.currentAnimation, 
                player.size, player.size, GraphicsUnit.Pixel);
        }
    }
}