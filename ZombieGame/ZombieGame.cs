using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZombieGame
{
    public partial class TL_ZombieGameForm : Form
    {
        public TL_ZombieGameForm()
        {
            InitializeComponent();
        }

        bool goUp;
        bool goDown;
        bool goLeft;
        bool goRight;
        string facing = "up";
        double playerHealth = 100;
        int ammo = 10;
        int playerSpeed = 10;
        int zombieSpeed = 3;
        int score = 0;
        bool gameOver= false;
        Random rnd = new Random();


        private void TL_gameEngine(object sender, EventArgs e)
        {
            if (playerHealth > 1)
            {
                TL_healthBar.Value = Convert.ToInt32(playerHealth);
            }
            else
            {
                TL_player.Image = Properties.Resources.dead1;
                TL_gameTimer.Stop();
                gameOver = true;
            }

            TL_lblAmmo.Text = "Ammo: " + ammo;
            TL_lblKills.Text = "Kills: " + score;

            if(TL_healthBar.Value < 20)
            {
                TL_healthBar.ForeColor = Color.Red;
            }
            //Movement TL_player.Left <--Left is left edge
            if(goLeft && TL_player.Left > 0)
            {
                TL_player.Left -= playerSpeed;
            }
            else if(goRight && TL_player.Left + TL_player.Width < 930)
            {
                TL_player.Left += playerSpeed;
            }
            else if(goUp && TL_player.Top > 60)
            {
                TL_player.Top -= playerSpeed;
            }
            else if(goDown && TL_player.Top + TL_player.Height < 670)
            {
                TL_player.Top += playerSpeed;
            }

            //Ammo consuming & bullet hit & miss
            foreach(Control x in this.Controls)
            {
                if(x is PictureBox && x.Tag == "ammo")
                {
                    if(((PictureBox)x).Bounds.IntersectsWith(TL_player.Bounds))
                    {
                        this.Controls.Remove(((PictureBox)x));
                        ((PictureBox)x).Dispose();
                        ammo += 5;
                    }
                }
                else if(x is PictureBox && x.Tag =="bullet")
                {
                    if (((PictureBox)x).Left < 1 || ((PictureBox)x).Left > 930 || ((PictureBox)x).Top < 10 || ((PictureBox)x).Top > 700)
                    {
                        this.Controls.Remove(((PictureBox)x));// remove bullet from screen
                        ((PictureBox)x).Dispose();
                    }
                }
                //Zombie hits player & moves towards him
                if(x is PictureBox && x.Tag == "zombie" || x.Tag == "zombie2")
                {
                    if(((PictureBox)x).Bounds.IntersectsWith(TL_player.Bounds))
                    {
                        playerHealth -= 1;
                    }
                    //move zombies towards player
                    if(((PictureBox)x).Left > TL_player.Left)
                    {
                        ((PictureBox)x).Left -= zombieSpeed;
                        if (x.Tag == "zombie")
                        {
                            
                            ((PictureBox)x).Image = Properties.Resources.zleft;
                        }
                        else if(x.Tag == "zombie2")
                        {
                            ((PictureBox)x).Image = Properties.Resources.z2left;
                        }
                    }
                    if(((PictureBox)x).Top > TL_player.Top)
                    {
                        ((PictureBox)x).Top -= zombieSpeed;
                        
                        if(x.Tag == "zombie")
                        {
                            ((PictureBox)x).Image = Properties.Resources.zup;
                        }
                        else if(x.Tag == "zombie2")
                        {
                            ((PictureBox)x).Image = Properties.Resources.z2up;
                        }
                    }
                    if(((PictureBox)x).Left < TL_player.Left)
                    {
                        ((PictureBox)x).Left += zombieSpeed;
                        if( x.Tag == "zombie")
                        {
                            ((PictureBox)x).Image = Properties.Resources.zright;
                        }
                        else if(x.Tag == "zombie2")
                        {
                            ((PictureBox)x).Image = Properties.Resources.z2right;
                        }
                    }
                    if(((PictureBox)x).Top < TL_player.Top)
                    {
                        ((PictureBox)x).Top += zombieSpeed;
                        if(x.Tag == "zombie")
                        {
                            ((PictureBox)x).Image = Properties.Resources.zdown;
                        }
                        else if(x.Tag == "zombie2")
                        {
                            ((PictureBox)x).Image = Properties.Resources.z2down;
                        }
                    }
                }
            }
        }

        private void TL_keyIsDown(object sender, KeyEventArgs e)
        {
            if (gameOver)
            {
                return;
            }
            //if key pressed
            if(e.KeyCode == Keys.Left)
            {
                goLeft = true;
                facing = "left";
                TL_player.Image = Properties.Resources.left;
            }
            else if(e.KeyCode == Keys.Right)
            {
                goRight = true;
                facing="right";
                TL_player.Image = Properties.Resources.right;
            }
            else if (e.KeyCode == Keys.Up)
            {
                goUp = true;
                facing = "up";
                TL_player.Image = Properties.Resources.up;
            }
            else if (e.KeyCode == Keys.Down)
            {
                goDown = true;
                facing = "down";
                TL_player.Image = Properties.Resources.down;
            }
        }

        private void TL_keyIsUp(object sender, KeyEventArgs e)
        {
            if(gameOver)
            {
                return;
            }

            if(e.KeyCode == Keys.Left)
            {
                goLeft = false;
            }
            else if(e.KeyCode == Keys.Right)
            {
                goRight = false;
            }
            else if (e.KeyCode == Keys.Up)
            {
                goUp = false;
            }
            else if (e.KeyCode == Keys.Down)
            {
                goDown = false;
            }
            else if (e.KeyCode == Keys.Space && ammo > 0)
            {
                ammo--;
                Shoot(facing);
                if(ammo < 0)
                {
                    DropAmmo();
                }

            }
        }

        private void DropAmmo() 
        {

        }

        private void Shoot(string direction)
        {

        }

        private void MakeZombies()
        {

        }
    }
}
