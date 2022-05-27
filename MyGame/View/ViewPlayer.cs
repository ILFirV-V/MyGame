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
            if (player.CurrentFrame < player.CurrentImageLimit - 1)
                player.CurrentFrame += 2;
            else player.CurrentFrame = 0;
            if (player.CharacterDied)
                player.CurrentFrame = 4;
            g.DrawImage(player.SpriteSheet, new Rectangle(new Point(player.PositionX - player.Direction * player.Size / 2, player.PositionY), 
                new Size(player.Direction * player.Size * 2, player.Size * 2)), 20 + 32 * player.CurrentFrame, 3 + 32 * player.CurrentAnimation, 
                player.Size, player.Size, GraphicsUnit.Pixel);
        }
    }
}