using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyGame.Models;

namespace MyGame.View
{
    class ViewMap
    {
        public static void DrawMap(Graphics g)
        {
            for (var i = 0; i < Map.mapWidth ;  i++)
            {
                for (var j = 0; j < Map.mapHeight; j++)
                {
                    switch (Map.getMapPieceType(i, j))
                    {
                        case 0:
                            PaintMap(g, i, j, 100, 0);
                            break;
                        case 1:
                            PaintMap(g, i, j, 320, 140);
                            break;
                        case 2:
                            PaintMap(g, i, j, 220, 60);
                            break;
                        case 3:
                            PaintMap(g, i, j, 80, 0);
                            break;
                        case 4:
                            PaintMap(g, i, j, 180, 40);
                            break;
                    }
                }
            }
        }

        public static void PaintMap(Graphics g, int i, int j, int widthCoordinates, int heightCoordinates)
        {
            g.DrawImage(Map.MapImage, new Rectangle(new Point(i * Map.mapConst, j * Map.mapConst), new Size(Map.mapConst, Map.mapConst)), widthCoordinates, heightCoordinates, 17, 17, GraphicsUnit.Pixel);
        }
    }
}
