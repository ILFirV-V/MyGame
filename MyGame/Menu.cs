using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyGame
{
    public partial class Menu : Form
    {
        public Menu()
        {
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            Size = Screen.PrimaryScreen.Bounds.Size;
            InitializeComponent();
        }

        private void StartGameButton_Click(object sender, EventArgs e)
        {
            var createForm = new Form1();
            this.Hide();
            createForm.Show();
        }

        private void ExitGameButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void InstructionButton_Click(object sender, EventArgs e)
        {
            instruction.Visible = true;
            buttonExitInstruction.Visible = true;
        }

        private void buttonExitInstruction_Click(object sender, EventArgs e)
        {
            instruction.Visible = false;
            buttonExitInstruction.Visible = false;
        }
    }
}
