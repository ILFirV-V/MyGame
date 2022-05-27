
namespace MyGame
{
    partial class Menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.StartGameButton = new System.Windows.Forms.Button();
            this.ExitGameButton = new System.Windows.Forms.Button();
            this.InstructionButton = new System.Windows.Forms.Button();
            this.instruction = new System.Windows.Forms.Label();
            this.buttonExitInstruction = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // StartGameButton
            // 
            this.StartGameButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.StartGameButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.StartGameButton.BackColor = System.Drawing.Color.Transparent;
            this.StartGameButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.StartGameButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.StartGameButton.Location = new System.Drawing.Point(264, 70);
            this.StartGameButton.Name = "StartGameButton";
            this.StartGameButton.Size = new System.Drawing.Size(277, 79);
            this.StartGameButton.TabIndex = 0;
            this.StartGameButton.Text = "Начать игру";
            this.StartGameButton.UseVisualStyleBackColor = false;
            this.StartGameButton.Click += new System.EventHandler(this.StartGameButton_Click);
            // 
            // ExitGameButton
            // 
            this.ExitGameButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ExitGameButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ExitGameButton.BackColor = System.Drawing.Color.LightGray;
            this.ExitGameButton.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ExitGameButton.Location = new System.Drawing.Point(264, 289);
            this.ExitGameButton.Name = "ExitGameButton";
            this.ExitGameButton.Size = new System.Drawing.Size(277, 69);
            this.ExitGameButton.TabIndex = 1;
            this.ExitGameButton.Text = "Выйти";
            this.ExitGameButton.UseVisualStyleBackColor = false;
            this.ExitGameButton.Click += new System.EventHandler(this.ExitGameButton_Click);
            // 
            // InstructionButton
            // 
            this.InstructionButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.InstructionButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.InstructionButton.BackColor = System.Drawing.Color.LightGray;
            this.InstructionButton.Location = new System.Drawing.Point(264, 182);
            this.InstructionButton.Name = "InstructionButton";
            this.InstructionButton.Size = new System.Drawing.Size(277, 72);
            this.InstructionButton.TabIndex = 2;
            this.InstructionButton.Text = "Инструкция";
            this.InstructionButton.UseVisualStyleBackColor = false;
            this.InstructionButton.Click += new System.EventHandler(this.InstructionButton_Click);
            // 
            // instruction
            // 
            this.instruction.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.instruction.BackColor = System.Drawing.Color.White;
            this.instruction.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.instruction.Location = new System.Drawing.Point(150, 98);
            this.instruction.Name = "instruction";
            this.instruction.Size = new System.Drawing.Size(507, 234);
            this.instruction.TabIndex = 3;
            this.instruction.Text = "W - вверх, S - вниз, \r\nA - влево, D - вправо.\r\nR - перезарядка оружия, \r\nесли ест" +
    "ь патроны.\r\nПробел - огонь из оружия,\r\nесли оружие заряжено.\r\n";
            this.instruction.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.instruction.Visible = false;
            this.instruction.Click += new System.EventHandler(this.label1_Click);
            // 
            // buttonExitInstruction
            // 
            this.buttonExitInstruction.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonExitInstruction.Location = new System.Drawing.Point(150, 335);
            this.buttonExitInstruction.Name = "buttonExitInstruction";
            this.buttonExitInstruction.Size = new System.Drawing.Size(507, 43);
            this.buttonExitInstruction.TabIndex = 4;
            this.buttonExitInstruction.Text = "Ок";
            this.buttonExitInstruction.UseVisualStyleBackColor = true;
            this.buttonExitInstruction.Visible = false;
            this.buttonExitInstruction.Click += new System.EventHandler(this.buttonExitInstruction_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(796, 470);
            this.Controls.Add(this.buttonExitInstruction);
            this.Controls.Add(this.instruction);
            this.Controls.Add(this.InstructionButton);
            this.Controls.Add(this.ExitGameButton);
            this.Controls.Add(this.StartGameButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Menu";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button StartGameButton;
        private System.Windows.Forms.Button ExitGameButton;
        private System.Windows.Forms.Button InstructionButton;
        private System.Windows.Forms.Label instruction;
        private System.Windows.Forms.Button buttonExitInstruction;
    }
}