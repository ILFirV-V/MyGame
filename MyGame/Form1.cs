using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyGame.Entites;
using MyGame.Models;

namespace MyGame
{
    public partial class Form1 : Form
    {
        public Image playerSheet;
        public Image minotaurSheet;
        private Entity player;

        public Form1()
        {
            InitializeComponent();
            Init();
        }

        public void Init()
        {
            var directoryInfo = new DirectoryInfo(Directory.GetCurrentDirectory()).Parent;
            if (directoryInfo != null)
                playerSheet =
                    new Bitmap(Path.Combine(
                        directoryInfo.Parent.FullName,
                        "Sprites\\Player.png"));

            player = new Entity(100, 100, Hero.idleFrames, Hero.runFrames, Hero.attackFrames, Hero.deathFrames, playerSheet);

            Invalidate();
        }

        private void OnPaint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawImage(playerSheet, new Rectangle(new Point(player.posX, player.posY), new Size(player.size, player.size)), 10, 10, player.size, player.size, GraphicsUnit.Pixel);
        }
    }
}