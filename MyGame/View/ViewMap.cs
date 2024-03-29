﻿using System;
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
            for (var i = 0; i < Map.mapWidth ;  i++)
            {
                for (var j = 0; j < Map.mapHeight; j++)
                {
                    switch (Map.getMapPieceType(i, j))
                    {
                        case 0:
                            PaintPartMap(g, i, j, 100, 0);
                            break;
                        case 1:
                            PaintPartMap(g, i, j, 320, 140);
                            break;
                        case 2:
                            PaintPartMap(g, i, j, 220, 60);
                            break;
                        case 3:
                            PaintPartMap(g, i, j, 80, 0);
                            break;
                        case 4:
                            PaintPartMap(g, i, j, 180, 40);
                            break;
                        case 5:
                            PaintPartMap(g, i, j, 140, 60);
                            break;
                        case 6:
                            PaintPartMap(g, i, j, 320, 140);
                            PaintPartMap(g, i, j, 260, 140);
                            break;
                        case 7:
                            PaintPartMap(g, i, j, 320, 140);
                            PaintPartMap(g, i, j, 280, 140);
                            break;
                        case 8:
                            PaintPartMap(g, i, j, 320, 140);
                            PaintPartMap(g, i, j, 300, 140);
                            break;
                        case 9:
                            PaintPartMap(g, i, j, 320, 140);
                            PaintDiamonds(i, j, g, player);
                            break;
                        case 10:
                            PaintPartMap(g, i, j, 320, 140);
                            PaintPartMap(g, i, j, 200, 120);
                            break;
                        case 11:
                            PaintPartMap(g, i, j, 320, 140);
                            PaintPartMap(g, i, j, 200, 100);
                            break;
                        case 12:
                            PaintPartMap(g, i, j, 320, 140);
                            PaintPartMap(g, i, j, 120, 120);
                            break;
                        case 14:
                            PaintPartMap(g, i, j, 160, 40);
                            break;
                        case 15:
                            PaintPartMap(g, i, j, 320, 140);
                            break;
                        case 16:
                            PaintPartMap(g, i, j, 320, 140);
                            player.CollectThings();
                            if (!player.IsHaveKey)
                                PaintPartMap(g, i, j, 140, 20);
                            break;
                        case 17:
                            PaintPartMap(g, i, j, 320, 140);
                            PaintCartridges(i, j, g, player);
                            break;
                        case 19:
                            PaintPartMap(g, i, j, 140, 40);
                            break;
                        case 20:
                            PaintPartMap(g, i, j, 320, 140);
                            PaintLifePlayer(50, 25, i, j, g, player);
                            break;
                        case 21:
                            PaintPartMap(g, i, j, 320, 140);
                            PaintLifePlayer(100, 75, i, j, g, player);
                            break;
                        case 22:
                            PaintPartMap(g, i, j, 320, 140);
                            PaintLifePlayer(150, 125, i, j, g, player);
                            break;
                        case 23:
                            PaintPartMap(g, i, j, 320, 140);
                            PaintLifePlayer(200, 175, i, j, g, player);
                            break;
                        case 24:
                            PaintPartMap(g, i, j, 320, 140);
                            PaintLifePlayer(250, 225, i, j, g, player);
                            break;
                        case 51:
                            PaintPartMap(g, i, j, 320, 140);
                            PaintPartMap(g, i, j, 140, 20);
                            break;
                        case 52:
                            PaintPartMap(g, i, j, 320, 140);
                            PaintPartMap(g, i, j, 200 + (player.IsHaveKey ? 20 : 0), 160);
                            break;
                        case 53:
                            PaintPartMap(g, i, j, 320, 140);
                            PaintPartMap(g, i, j, 160, 0);
                            break;
                        case 54:
                            PaintPartMap(g, i, j, 320, 140);
                            PaintPartMap(g, i, j, 200 + (player.Weapon.CartridgesCount / 100) * 20, 160);
                            break;
                        case 55:
                            PaintPartMap(g, i, j, 320, 140);
                            PaintPartMap(g, i, j, 200 + ((player.Weapon.CartridgesCount / 10) % 10) * 20, 160);
                            break;
                        case 56:
                            PaintPartMap(g, i, j, 320, 140);
                            PaintPartMap(g, i, j, 200 + (player.Weapon.CartridgesCount % 10) * 20, 160);
                            break;
                        case 57:
                            PaintPartMap(g, i, j, 320, 140);
                            PaintPartMap(g, i, j, 140, 60);
                            break;
                        case 58:
                            PaintPartMap(g, i, j, 320, 140);
                            PaintPartMap(g, i, j, 200 + (player.DiamondsCount / 10) * 20, 160);
                            break;
                        case 59:
                            PaintPartMap(g, i, j, 320, 140);
                            PaintPartMap(g, i, j, 200 + (player.DiamondsCount % 10) * 20, 160);
                            break;
                    }
                }
            }
        }

        public static void PaintLifePlayer(int wholeLife, int halfLife, int i, int j, Graphics g, Player player)
        {
            PaintPartMap(g, i, j, player.XP >= halfLife ? 100 : 120, 40);
            PaintPartMap(g, i, j, player.XP >= wholeLife ? 80 : 120, 40);
        }

        public static void PaintDiamonds(int i, int j, Graphics g, Player player)
        {
            player.CollectThings();
            if (!player.CollectedDiamonds.Contains((i, j)) || player.CollectedDiamonds == null)
                PaintPartMap(g, i, j, 140, 60);
        }

        public static void PaintCartridges(int i, int j, Graphics g, Player player)
        {
            player.CollectThings();
            if (!player.CollectedCartridges.Contains((i, j)) || player.CollectedCartridges == null)
                PaintPartMap(g, i, j, 160, 0);
        }

        public static void PaintPartMap(Graphics g, int i, int j, int widthCoordinates, int heightCoordinates)
        {
            g.DrawImage(Map.MapImage, new Rectangle(new Point(i * Map.mapConst, j * Map.mapConst), new Size(Map.mapConst, Map.mapConst)), widthCoordinates, heightCoordinates, 17, 17, GraphicsUnit.Pixel);
        }
    }
}
