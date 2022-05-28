
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
            this.StartGameButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.StartGameButton.Font = new System.Drawing.Font("Clarendon Blk BT", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartGameButton.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.StartGameButton.Image = ((System.Drawing.Image)(resources.GetObject("StartGameButton.Image")));
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
            this.ExitGameButton.Font = new System.Drawing.Font("Clarendon Blk BT", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitGameButton.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.ExitGameButton.Image = ((System.Drawing.Image)(resources.GetObject("ExitGameButton.Image")));
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
            this.InstructionButton.Font = new System.Drawing.Font("Clarendon Blk BT", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InstructionButton.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.InstructionButton.Image = ((System.Drawing.Image)(resources.GetObject("InstructionButton.Image")));
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
            this.instruction.Font = new System.Drawing.Font("Clarendon Blk BT", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instruction.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.instruction.Image = ((System.Drawing.Image)(resources.GetObject("instruction.Image")));
            this.instruction.Location = new System.Drawing.Point(26, 73);
            this.instruction.Name = "instruction";
            this.instruction.Size = new System.Drawing.Size(734, 285);
            this.instruction.TabIndex = 3;
            this.instruction.Text = resources.GetString("instruction.Text");
            this.instruction.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.instruction.Visible = false;
            this.instruction.Click += new System.EventHandler(this.instruction_Click);
            // 
            // buttonExitInstruction
            // 
            this.buttonExitInstruction.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonExitInstruction.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonExitInstruction.Font = new System.Drawing.Font("Clarendon Blk BT", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExitInstruction.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.buttonExitInstruction.Image = ((System.Drawing.Image)(resources.GetObject("buttonExitInstruction.Image")));
            this.buttonExitInstruction.Location = new System.Drawing.Point(26, 364);
            this.buttonExitInstruction.Name = "buttonExitInstruction";
            this.buttonExitInstruction.Size = new System.Drawing.Size(734, 60);
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