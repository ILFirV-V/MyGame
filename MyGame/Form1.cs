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
using System.Xml.Serialization;
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

            timer1.Interval = 20;
            timer1.Tick += Update;

            KeyDown += OnPress;
            KeyUp += OnKeyUp;
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

            player = new Entity(100, 100, Hero.idleFrames, Hero.runFrames, Hero.attackFrames, Hero.deathFrames, playerSheet, 30);

            timer1.Start();
        }

        public void Update(object sender, EventArgs e)
        {
            if(player.isMoving)
                player.Move();
            Invalidate();
        }

        public void OnPress(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W:
                    player.dirY = -2;
                    break;
                case Keys.S:
                    player.dirY = 2;
                    break;
                case Keys.D:
                    player.dirX = 2;
                    break;
                case Keys.A:
                    player.dirX = -2;
                    break;
            }
            player.isMoving = true;
        }

        public void OnKeyUp(object sender, KeyEventArgs e)
        {
            player.dirX = 0;
            player.dirY = 0;
            player.isMoving = false;
        }

        private void OnPaint(object sender, PaintEventArgs e)
        {
            var g = e.Graphics;
            player.Play(sender, g);
        }
    }
}