namespace ZombieGame
{
    partial class Instruction
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
            this.TL_lblGame = new System.Windows.Forms.Label();
            this.TL_lblSpc = new System.Windows.Forms.Label();
            this.TL_lblArrow = new System.Windows.Forms.Label();
            this.TL_btnStartGame = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TL_lblGame
            // 
            this.TL_lblGame.Font = new System.Drawing.Font("Algerian", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TL_lblGame.ForeColor = System.Drawing.Color.Maroon;
            this.TL_lblGame.Location = new System.Drawing.Point(57, 27);
            this.TL_lblGame.Name = "TL_lblGame";
            this.TL_lblGame.Size = new System.Drawing.Size(372, 43);
            this.TL_lblGame.TabIndex = 0;
            this.TL_lblGame.Text = "Zombie Shooter Game";
            // 
            // TL_lblSpc
            // 
            this.TL_lblSpc.AutoSize = true;
            this.TL_lblSpc.Location = new System.Drawing.Point(73, 114);
            this.TL_lblSpc.Name = "TL_lblSpc";
            this.TL_lblSpc.Size = new System.Drawing.Size(344, 21);
            this.TL_lblSpc.TabIndex = 1;
            this.TL_lblSpc.Text = "To shoot zombies press spacebar";
            // 
            // TL_lblArrow
            // 
            this.TL_lblArrow.AutoSize = true;
            this.TL_lblArrow.Location = new System.Drawing.Point(87, 164);
            this.TL_lblArrow.Name = "TL_lblArrow";
            this.TL_lblArrow.Size = new System.Drawing.Size(310, 21);
            this.TL_lblArrow.TabIndex = 2;
            this.TL_lblArrow.Text = "For movement use arrow keys";
            // 
            // TL_btnStartGame
            // 
            this.TL_btnStartGame.ForeColor = System.Drawing.Color.Maroon;
            this.TL_btnStartGame.Location = new System.Drawing.Point(167, 239);
            this.TL_btnStartGame.Name = "TL_btnStartGame";
            this.TL_btnStartGame.Size = new System.Drawing.Size(144, 43);
            this.TL_btnStartGame.TabIndex = 3;
            this.TL_btnStartGame.Text = "Start Game";
            this.TL_btnStartGame.UseVisualStyleBackColor = true;
            this.TL_btnStartGame.Click += new System.EventHandler(this.TL_btnStartGame_Click);
            // 
            // Instruction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.TL_btnStartGame);
            this.Controls.Add(this.TL_lblArrow);
            this.Controls.Add(this.TL_lblSpc);
            this.Controls.Add(this.TL_lblGame);
            this.Font = new System.Drawing.Font("Algerian", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Instruction";
            this.Text = "Instruction";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TL_lblGame;
        private System.Windows.Forms.Label TL_lblSpc;
        private System.Windows.Forms.Label TL_lblArrow;
        private System.Windows.Forms.Button TL_btnStartGame;
    }
}