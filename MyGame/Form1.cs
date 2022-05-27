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
        public Image leshySheet;
        private Enemy leshy;
        public Image adventurerSheet;
        private Enemy adventurer;
        private ControllerPlayer controller;

        public Form1()
        {
            InitializeComponent();
            timer1.Interval = 30;
            timer1.Tick += UpdatePlayer;
            timer2.Interval = 35;
            timer2.Tick += UpdateBattle;
            timer2.Tick += UpdateEnemy;

            Init();
            controller = new ControllerPlayer(player);
            KeyDown += controller.OnPress;
            KeyUp += controller.OnKeyUp;
            Size = Screen.PrimaryScreen.Bounds.Size;
            WindowState = FormWindowState.Maximized;
            //FormBorderStyle = FormBorderStyle.None;
            player.positionX = 250;
            player.positionY = ClientSize.Height - Map.mapConst * 6;
            leshy.positionX = 350;
            leshy.positionY = ClientSize.Height - Map.mapConst * 6;
            adventurer.positionX = 550;
            adventurer.positionY = ClientSize.Height - Map.mapConst * 12; 
            MaximizeBox = false;
        }

        public void Init()
        {
            Map.Init();

            var directoryInfoPlayer = new DirectoryInfo(Directory.GetCurrentDirectory()).Parent;
            if (directoryInfoPlayer != null)
                playerSheet = new Bitmap(Path.Combine(directoryInfoPlayer.Parent.FullName, "Sprites\\Player.png"));
            player = new Player(100, 100, playerSheet, 35, 1, 8, 4, 5);

            var directoryInfoLeshy = new DirectoryInfo(Directory.GetCurrentDirectory()).Parent;
            if (directoryInfoLeshy != null)
                leshySheet = new Bitmap(Path.Combine(directoryInfoLeshy.Parent.FullName, "Sprites\\Leshy.png"));
            leshy = new Enemy(100, 100, leshySheet, 35, 1, 8, 6, 6, player, 50, 0, 1, 2, 4);

            var directoryInfoShardsoul = new DirectoryInfo(Directory.GetCurrentDirectory()).Parent;
            if (directoryInfoShardsoul != null)
                adventurerSheet = new Bitmap(Path.Combine(directoryInfoShardsoul.Parent.FullName, "Sprites\\Adventurer.png"));
            adventurer = new Enemy(100, 100, adventurerSheet, 35, 1, 8, 6, 6, player, 100, 0, 1, 6, 5);
            timer2.Start();
            timer1.Start();

        }

        public void UpdatePlayer(object sender, EventArgs e)
        {
            player.Move();
            player.Attack();
            player.Jump1();

            player.StateOnMap();
        }

        public void UpdateBattle(object sender, EventArgs e)
        {
            leshy.Battle();
            adventurer.Battle();
        }

        public void UpdateEnemy(object sender, EventArgs e)
        {
            leshy.Fall();
            if (leshy.isMoving)
                leshy.Move();
            adventurer.Fall();
            if (adventurer.isMoving)
                adventurer.Move();
            leshy.Battle();
            adventurer.Battle();
            Invalidate();
        }

        private void OnPaint(object sender, PaintEventArgs e)
        {
            var g = e.Graphics;
            ViewMap.DrawMap(g, player);
            ViewPlayer.PlayerAnimation(sender, g, player);
            ViewEnemy.EnemyAnimation(sender, g, leshy);
            ViewEnemy.EnemyAnimation(sender, g, adventurer);
        }
    }
}