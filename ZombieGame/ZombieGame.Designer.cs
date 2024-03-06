namespace ZombieGame
{
    partial class TL_ZombieGameForm
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
            this.components = new System.ComponentModel.Container();
            this.TL_lblAmmo = new System.Windows.Forms.Label();
            this.TL_lblHealth = new System.Windows.Forms.Label();
            this.TL_lblKills = new System.Windows.Forms.Label();
            this.TL_healthBar = new System.Windows.Forms.ProgressBar();
            this.TL_zombie2 = new System.Windows.Forms.PictureBox();
            this.TL_player = new System.Windows.Forms.PictureBox();
            this.TL_gameTimer = new System.Windows.Forms.Timer(this.components);
            this.TL_zombie = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.TL_zombie2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TL_player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TL_zombie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // TL_lblAmmo
            // 
            this.TL_lblAmmo.AutoSize = true;
            this.TL_lblAmmo.BackColor = System.Drawing.Color.Transparent;
            this.TL_lblAmmo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.TL_lblAmmo.ForeColor = System.Drawing.Color.White;
            this.TL_lblAmmo.Location = new System.Drawing.Point(16, 37);
            this.TL_lblAmmo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TL_lblAmmo.Name = "TL_lblAmmo";
            this.TL_lblAmmo.Size = new System.Drawing.Size(128, 31);
            this.TL_lblAmmo.TabIndex = 0;
            this.TL_lblAmmo.Text = "Ammo: 0";
            // 
            // TL_lblHealth
            // 
            this.TL_lblHealth.AutoSize = true;
            this.TL_lblHealth.BackColor = System.Drawing.Color.Transparent;
            this.TL_lblHealth.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.TL_lblHealth.ForeColor = System.Drawing.Color.White;
            this.TL_lblHealth.Location = new System.Drawing.Point(875, 37);
            this.TL_lblHealth.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TL_lblHealth.Name = "TL_lblHealth";
            this.TL_lblHealth.Size = new System.Drawing.Size(108, 31);
            this.TL_lblHealth.TabIndex = 1;
            this.TL_lblHealth.Text = "Health:";
            // 
            // TL_lblKills
            // 
            this.TL_lblKills.AutoSize = true;
            this.TL_lblKills.BackColor = System.Drawing.Color.Transparent;
            this.TL_lblKills.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.TL_lblKills.ForeColor = System.Drawing.Color.White;
            this.TL_lblKills.Location = new System.Drawing.Point(505, 37);
            this.TL_lblKills.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TL_lblKills.Name = "TL_lblKills";
            this.TL_lblKills.Size = new System.Drawing.Size(102, 31);
            this.TL_lblKills.TabIndex = 2;
            this.TL_lblKills.Text = "Kills: 0";
            // 
            // TL_healthBar
            // 
            this.TL_healthBar.Location = new System.Drawing.Point(981, 39);
            this.TL_healthBar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TL_healthBar.Name = "TL_healthBar";
            this.TL_healthBar.Size = new System.Drawing.Size(196, 28);
            this.TL_healthBar.TabIndex = 3;
            // 
            // TL_zombie2
            // 
            this.TL_zombie2.BackColor = System.Drawing.Color.Transparent;
            this.TL_zombie2.Image = global::ZombieGame.Properties.Resources.z2up;
            this.TL_zombie2.Location = new System.Drawing.Point(547, 688);
            this.TL_zombie2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TL_zombie2.Name = "TL_zombie2";
            this.TL_zombie2.Size = new System.Drawing.Size(71, 72);
            this.TL_zombie2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.TL_zombie2.TabIndex = 6;
            this.TL_zombie2.TabStop = false;
            this.TL_zombie2.Tag = "zombie2";
            // 
            // TL_player
            // 
            this.TL_player.BackColor = System.Drawing.Color.Transparent;
            this.TL_player.Image = global::ZombieGame.Properties.Resources.up;
            this.TL_player.Location = new System.Drawing.Point(565, 374);
            this.TL_player.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TL_player.Name = "TL_player";
            this.TL_player.Size = new System.Drawing.Size(57, 110);
            this.TL_player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.TL_player.TabIndex = 7;
            this.TL_player.TabStop = false;
            this.TL_player.Tag = "player";
            // 
            // TL_gameTimer
            // 
            this.TL_gameTimer.Enabled = true;
            this.TL_gameTimer.Interval = 20;
            this.TL_gameTimer.Tick += new System.EventHandler(this.TL_gameEngine);
            // 
            // TL_zombie
            // 
            this.TL_zombie.BackColor = System.Drawing.Color.Transparent;
            this.TL_zombie.Image = global::ZombieGame.Properties.Resources.zdown;
            this.TL_zombie.Location = new System.Drawing.Point(101, 185);
            this.TL_zombie.Margin = new System.Windows.Forms.Padding(4);
            this.TL_zombie.Name = "TL_zombie";
            this.TL_zombie.Size = new System.Drawing.Size(71, 71);
            this.TL_zombie.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.TL_zombie.TabIndex = 4;
            this.TL_zombie.TabStop = false;
            this.TL_zombie.Tag = "zombie";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::ZombieGame.Properties.Resources.zdown;
            this.pictureBox1.Location = new System.Drawing.Point(1029, 185);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(71, 71);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "zombie";
            // 
            // TL_ZombieGameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1231, 820);
            this.Controls.Add(this.TL_player);
            this.Controls.Add(this.TL_zombie2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.TL_zombie);
            this.Controls.Add(this.TL_healthBar);
            this.Controls.Add(this.TL_lblKills);
            this.Controls.Add(this.TL_lblHealth);
            this.Controls.Add(this.TL_lblAmmo);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "TL_ZombieGameForm";
            this.Text = "ZombieGame";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TL_keyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TL_keyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.TL_zombie2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TL_player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TL_zombie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TL_lblAmmo;
        private System.Windows.Forms.Label TL_lblHealth;
        private System.Windows.Forms.Label TL_lblKills;
        private System.Windows.Forms.ProgressBar TL_healthBar;
        private System.Windows.Forms.PictureBox TL_zombie2;
        private System.Windows.Forms.PictureBox TL_player;
        private System.Windows.Forms.Timer TL_gameTimer;
        private System.Windows.Forms.PictureBox TL_zombie;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

