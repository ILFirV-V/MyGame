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
using MyGame.Controllers;
using MyGame.Models;
using MyGame.View;

namespace MyGame
{
    public partial class Form1 : Form
    {
        public Image playerSheet;
        private Player player;
        private ControllerPlayer controller;

        public Form1()
        {
            InitializeComponent();
            timer1.Interval = 30;
            timer1.Tick += Update;
            Init();
            controller = new ControllerPlayer(player);
            KeyDown += controller.OnPress;
            KeyUp += controller.OnKeyUp;

            WindowState = FormWindowState.Maximized;
            //FormBorderStyle = FormBorderStyle.None;
            player.positionX = Right + 329;
            player.positionY = Bottom - 24;
            MaximizeBox = false;

        }

        public void Init()
        {
            Map.Init();

            var directoryInfo = new DirectoryInfo(Directory.GetCurrentDirectory()).Parent;
            if (directoryInfo != null)
                playerSheet = new Bitmap(Path.Combine(directoryInfo.Parent.FullName, "Sprites\\Player.png"));
            player = new Player(100, 100, playerSheet, 30, 1, 8, 4, 5);
            timer1.Start();
        }

        public void Update(object sender, EventArgs e)
        {
            if (player.isMoving)
                player.Move();
            Invalidate();
        }

        private void OnPaint(object sender, PaintEventArgs e)
        {
            var g = e.Graphics;
            ViewMap.DrawMap(g);
            ViewPlayer.PlayerAnimation(sender, g, player);
        }
    }
}