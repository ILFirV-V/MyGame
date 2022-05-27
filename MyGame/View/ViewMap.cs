using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyGame.Controllers;
using MyGame.Models;

namespace MyGame.View
{
    class ViewMap
    {
        public static void DrawMap(Graphics g, Player player)
        {
            var a = 0;
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
                        case 5:
                            PaintMap(g, i, j, 140, 60);
                            break;
                        case 6:
                            PaintMap(g, i, j, 320, 140);
                            PaintMap(g, i, j, 260, 140);
                            break;
                        case 7:
                            PaintMap(g, i, j, 320, 140);
                            PaintMap(g, i, j, 280, 140);
                            break;
                        case 8:
                            PaintMap(g, i, j, 320, 140);
                            PaintMap(g, i, j, 300, 140);
                            break;
                        case 9:
                            PaintMap(g, i, j, 320, 140);
                            player.isCollectsDiamond();
                            if ((!player.collectedDiamonds.Contains((i, j))) || player.collectedDiamonds == null)
                                PaintMap(g, i, j, 140, 60);
                            break;
                        case 10:
                            PaintMap(g, i, j, 320, 140);
                            PaintMap(g, i, j, 200, 120);
                            break;
                        case 11:
                            PaintMap(g, i, j, 320, 140);
                            PaintMap(g, i, j, 200, 100);
                            break;
                        case 12:
                            PaintMap(g, i, j, 320, 140);
                            PaintMap(g, i, j, 120, 120);
                            break;
                        case 14:
                            PaintMap(g, i, j, 320, 140);
                            PaintMap(g, i, j, 200 + player.diamonds * 20, 160);
                            break;
                        case 15:
                            PaintMap(g, i, j, 320, 140);
                            break;
                        case 16:
                            PaintMap(g, i, j, 320, 140);
                            PaintMap(g, i, j, 140, 60);
                            break;
                        case 20:
                            PaintMap(g, i, j, 320, 140);
                            PaintMap(g, i, j, player.XP >= 25 ? 100 : 120, 40);
                            PaintMap(g, i, j, player.XP >= 50 ? 80 : 120, 40);
                            break;
                        case 21:
                            PaintMap(g, i, j, 320, 140);
                            PaintMap(g, i, j, player.XP >= 75 ? 100 : 120, 40);
                            PaintMap(g, i, j, player.XP >= 100 ? 80 : 120, 40);
                            break;
                        case 22:
                            PaintMap(g, i, j, 320, 140);
                            PaintMap(g, i, j, player.XP >= 125 ? 100 : 120, 40);
                            PaintMap(g, i, j, player.XP >= 150 ? 80 : 120, 40);
                            break;
                        case 23:
                            PaintMap(g, i, j, 320, 140);
                            PaintMap(g, i, j, player.XP >= 175 ? 100 : 120, 40);
                            PaintMap(g, i, j, player.XP >= 200 ? 80 : 120, 40);
                            break;
                        case 24:
                            PaintMap(g, i, j, 320, 140);
                            PaintMap(g, i, j, player.XP >= 225 ? 100 : 120, 40);
                            PaintMap(g, i, j, player.XP >= 250 ? 80 : 120, 40);
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
