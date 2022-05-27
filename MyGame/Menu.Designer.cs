
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
            this.StartGameButton = new System.Windows.Forms.Button();
            this.ExitGameButton = new System.Windows.Forms.Button();
            this.InstructionButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // StartGameButton
            // 
            this.StartGameButton.Location = new System.Drawing.Point(242, 100);
            this.StartGameButton.Name = "StartGameButton";
            this.StartGameButton.Size = new System.Drawing.Size(150, 39);
            this.StartGameButton.TabIndex = 0;
            this.StartGameButton.Text = "Начать игру";
            this.StartGameButton.UseVisualStyleBackColor = true;
            this.StartGameButton.Click += new System.EventHandler(this.StartGameButton_Click);
            // 
            // ExitGameButton
            // 
            this.ExitGameButton.Location = new System.Drawing.Point(242, 234);
            this.ExitGameButton.Name = "ExitGameButton";
            this.ExitGameButton.Size = new System.Drawing.Size(150, 31);
            this.ExitGameButton.TabIndex = 1;
            this.ExitGameButton.Text = "Выйти";
            this.ExitGameButton.UseVisualStyleBackColor = true;
            this.ExitGameButton.Click += new System.EventHandler(this.ExitGameButton_Click);
            // 
            // InstructionButton
            // 
            this.InstructionButton.Location = new System.Drawing.Point(242, 161);
            this.InstructionButton.Name = "InstructionButton";
            this.InstructionButton.Size = new System.Drawing.Size(150, 36);
            this.InstructionButton.TabIndex = 2;
            this.InstructionButton.Text = "Инструкция";
            this.InstructionButton.UseVisualStyleBackColor = true;
            this.InstructionButton.Click += new System.EventHandler(this.InstructionButton_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 470);
            this.Controls.Add(this.InstructionButton);
            this.Controls.Add(this.ExitGameButton);
            this.Controls.Add(this.StartGameButton);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button StartGameButton;
        private System.Windows.Forms.Button ExitGameButton;
        private System.Windows.Forms.Button InstructionButton;
    }
}