using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyGame.Models;

namespace MyGame.View
{
    class ViewMap
    {
        public static void DrawMap(Graphics g)
        {
            for (var i = 0; i < Map.mapHeight; i++)
            {
                for (var j = 0; j < Map.mapWidth; j++)
                {
                    if (Map.getMapPieceType(i, j) == 1)
                    {
                        g.DrawImage(Map.MapImage, new Rectangle(new Point(i * Map.size.Width, j * Map.size.Height), Map.size), 320, 140, 15, 15, GraphicsUnit.Pixel);
                    }
                }
            }
        }
    }
}
