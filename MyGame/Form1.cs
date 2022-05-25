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
        public Image twigSheet;
        private Enemy twig;
        public Image adventurerSheet;
        private Enemy adventurer;
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
            Size = Screen.PrimaryScreen.Bounds.Size;
            WindowState = FormWindowState.Maximized;
            //FormBorderStyle = FormBorderStyle.None;
            player.positionX = 250;
            player.positionY = ClientSize.Height - Map.mapConst * 6;
            twig.positionX = ClientSize.Width - 250;
            twig.positionY = ClientSize.Height - Map.mapConst * 12;
            adventurer.positionX = 550;
            adventurer.positionY = ClientSize.Height - Map.mapConst * 6;
            MaximizeBox = false;
        }

        public void Init()
        {
            Map.Init();

            var directoryInfoPlayer = new DirectoryInfo(Directory.GetCurrentDirectory()).Parent;
            if (directoryInfoPlayer != null)
                playerSheet = new Bitmap(Path.Combine(directoryInfoPlayer.Parent.FullName, "Sprites\\Player.png"));
            player = new Player(100, 100, playerSheet, 30, 1, 8, 4, 5);

            var directoryInfoTwig = new DirectoryInfo(Directory.GetCurrentDirectory()).Parent;
            if (directoryInfoTwig != null)
                twigSheet = new Bitmap(Path.Combine(directoryInfoTwig.Parent.FullName, "Sprites\\Twig.png"));
            twig = new Enemy(100, 100, twigSheet, 30, 1, 8, 9, 6, player, 3);

            var directoryInfoShardsoul = new DirectoryInfo(Directory.GetCurrentDirectory()).Parent;
            if (directoryInfoShardsoul != null)
                adventurerSheet = new Bitmap(Path.Combine(directoryInfoShardsoul.Parent.FullName, "Sprites\\Adventurer.png"));
            adventurer = new Enemy(100, 100, adventurerSheet, 30, 1, 8, 9, 6, player, 7);

            timer1.Start();
        }

        public void Update(object sender, EventArgs e)
        {
            player.Move();
            player.Jump();
            twig.Fall();
            if(twig.isMoving)
                twig.Move();
            adventurer.Fall();
            if (adventurer.isMoving)
                adventurer.Move();
            Invalidate();
        }

        private void OnPaint(object sender, PaintEventArgs e)
        {
            var g = e.Graphics;
            ViewMap.DrawMap(g, player);
            ViewEnemy.EnemyAnimation(sender, g, twig);
            ViewEnemy.EnemyAnimation(sender, g, adventurer);
            ViewPlayer.PlayerAnimation(sender, g, player);
        }
    }
}