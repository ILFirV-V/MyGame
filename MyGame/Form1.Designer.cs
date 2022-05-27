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
            this.SuspendLayout();
            // 
            // inscriptionVictoryGame
            // 
            this.inscriptionVictoryGame.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.inscriptionVictoryGame.Font = new System.Drawing.Font("Mistral", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inscriptionVictoryGame.Location = new System.Drawing.Point(169, 96);
            this.inscriptionVictoryGame.Name = "inscriptionVictoryGame";
            this.inscriptionVictoryGame.Size = new System.Drawing.Size(295, 151);
            this.inscriptionVictoryGame.TabIndex = 0;
            this.inscriptionVictoryGame.Text = "Victory Game";
            this.inscriptionVictoryGame.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.inscriptionVictoryGame.Visible = false;
            this.inscriptionVictoryGame.Enter += new System.EventHandler(this.InscriptionVictoryGame_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1500, 800);
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
    }
}

