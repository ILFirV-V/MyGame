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
            InitializeComponent();
        }

        private void StartGameButton_Click(object sender, EventArgs e)
        {
            var create = false;
            foreach (Form form in Application.OpenForms)
            {
                if (form.Name.ToString() == "Form1")
                {
                    this.Hide();
                    form.Visible = true;
                    create = true;
                    break;
                }
            }
            if (create == false)
            {
                var createForm = new Form1();
                this.Hide();
                createForm.Show();
            }
        }

        private void ExitGameButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void InstructionButton_Click(object sender, EventArgs e)
        {

        }
    }
}
