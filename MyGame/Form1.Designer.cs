using MyGame.Controllers;

namespace MyGame
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.inscriptionVictoryGame = new System.Windows.Forms.Label();
            this.buttonOutMenu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // inscriptionVictoryGame
            // 
            this.inscriptionVictoryGame.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.inscriptionVictoryGame.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.inscriptionVictoryGame.Font = new System.Drawing.Font("Mistral", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inscriptionVictoryGame.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.inscriptionVictoryGame.Image = ((System.Drawing.Image)(resources.GetObject("inscriptionVictoryGame.Image")));
            this.inscriptionVictoryGame.Location = new System.Drawing.Point(410, 143);
            this.inscriptionVictoryGame.Name = "inscriptionVictoryGame";
            this.inscriptionVictoryGame.Size = new System.Drawing.Size(661, 400);
            this.inscriptionVictoryGame.TabIndex = 0;
            this.inscriptionVictoryGame.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.inscriptionVictoryGame.Visible = false;
            this.inscriptionVictoryGame.Enter += new System.EventHandler(this.WithdrawInscriptionVictoryGame_Click);
            // 
            // buttonOutMenu
            // 
            this.buttonOutMenu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonOutMenu.Font = new System.Drawing.Font("Mistral", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonOutMenu.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.buttonOutMenu.Image = ((System.Drawing.Image)(resources.GetObject("buttonOutMenu.Image")));
            this.buttonOutMenu.Location = new System.Drawing.Point(410, 546);
            this.buttonOutMenu.Name = "buttonOutMenu";
            this.buttonOutMenu.Size = new System.Drawing.Size(661, 120);
            this.buttonOutMenu.TabIndex = 1;
            this.buttonOutMenu.Text = "Выйти в меню";
            this.buttonOutMenu.UseVisualStyleBackColor = true;
            this.buttonOutMenu.Visible = false;
            this.buttonOutMenu.Click += new System.EventHandler(this.ButtonOutMenu_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1500, 800);
            this.Controls.Add(this.buttonOutMenu);
            this.Controls.Add(this.inscriptionVictoryGame);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.OnPaint);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Label inscriptionVictoryGame;
        private System.Windows.Forms.Button buttonOutMenu;
    }
}

