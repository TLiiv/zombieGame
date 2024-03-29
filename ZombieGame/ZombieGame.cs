﻿using System;
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
            RestartGame();
            
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
        List<PictureBox> zombiesList = new List<PictureBox>();

        
        private void TL_gameEngine(object sender, EventArgs e)
        {
            if (playerHealth > 1)
            {
                TL_healthBar.Value = Convert.ToInt32(playerHealth);
                
            }
            else
            {
                TL_player.Image = Properties.Resources.dead1;
                gameOver = true;
                TL_gameTimer.Stop();
                if (gameOver)
                {
                    TL_lblEnd.Visible = true;
                    TL_lblEnd.BringToFront();
                    TL_lblEndRestart.Visible = true;
                    TL_lblEndRestart.BringToFront();
                }
            }

            TL_lblAmmo.Text = "Ammo: " + ammo;
            TL_lblKills.Text = "Kills: " + score;

            


            //Movement TL_player.Left <--Left is left edge
            if (goLeft && TL_player.Left > 0)
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

                    //bullet hits zombie
                    foreach(Control j in this.Controls)
                    {
                        if((j is PictureBox && (string)j.Tag == "bullet") && (x is PictureBox && (string)x.Tag == "zombie" || (string)x.Tag =="zombie2"))
                        {
                            if (x.Bounds.IntersectsWith(j.Bounds))
                            {
                                score++;
                                this.Controls.Remove(j); //remove bullet from screen
                                j.Dispose(); // remove bullet from program
                                this.Controls.Remove(x); //remove zombie
                                x.Dispose();//remove zombie from program
                                zombiesList.Remove(((PictureBox)x));//remove from array also
                                MakeZombies();
                            }
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
            if(e.KeyCode == Keys.Right)
            {
                goRight = true;
                facing="right";
                TL_player.Image = Properties.Resources.right;
            }
            if (e.KeyCode == Keys.Up)
            {
                goUp = true;
                facing = "up";
                TL_player.Image = Properties.Resources.up;
            }
            if (e.KeyCode == Keys.Down)
            {
                goDown = true;
                facing = "down";
                TL_player.Image = Properties.Resources.down;
            }

        }

        private void TL_keyIsUp(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Left)
            {
                goLeft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                goRight = false;
            }
            if (e.KeyCode == Keys.Up)
            {
                goUp = false;
            }
            if (e.KeyCode == Keys.Down)
            {
                goDown = false;
            }
            if (e.KeyCode == Keys.Space && ammo > 0 && gameOver == false)
            {
                ammo--;
                Shoot(facing);
                if(ammo <= 0)
                {
                    DropAmmo();
                }
            }
            if(e.KeyCode == Keys.Enter && gameOver == true)
            {
                RestartGame();
            }
        }

        private void DropAmmo() 
        {
            //ammo spawn to random places
            PictureBox ammo = new PictureBox();
            ammo.Image = Properties.Resources.ammo_Image;
            ammo.SizeMode = PictureBoxSizeMode.AutoSize;
            ammo.Left = rnd.Next(20, 800);
            ammo.Top = rnd.Next(50,650);
            ammo.Tag = "ammo";
            this.Controls.Add(ammo);
            ammo.BringToFront(); //bring ammo forward
            TL_player.BringToFront(); // bring player forward
        }

        private void Shoot(string direction)
        {
            TL_bullet shootBullet = new TL_bullet();
            shootBullet.direction = direction;
            shootBullet.bulletLeft = TL_player.Left + (TL_player.Width / 2);
            shootBullet.bulletTop = TL_player.Top + (TL_player.Height / 2);
            shootBullet.MakeBullet(this);
        }

        private void MakeZombies()
        {
            int zombieNum = rnd.Next(1, 3);
            if(zombieNum == 1)
            {
                PictureBox zombie = new PictureBox();
                zombie.Tag = "zombie";
                zombie.Image = Properties.Resources.zdown;
                zombie.Left = rnd.Next(0, 900);
                zombie.Top = rnd.Next(0, 700);
                zombie.SizeMode = PictureBoxSizeMode.AutoSize;
               
                zombiesList.Add(zombie); 
                this.Controls.Add(zombie); 
                TL_player.BringToFront();
            }else if(zombieNum == 2)
            {
                PictureBox zombie2 = new PictureBox();
                zombie2.Tag = "zombie2";
                zombie2.Image = Properties.Resources.z2up;
                zombie2.Left = rnd.Next(0, 900);
                zombie2.Top = rnd.Next(0, 700);
                zombie2.SizeMode = PictureBoxSizeMode.AutoSize;
                zombiesList.Add(zombie2);
                this.Controls.Add(zombie2);
                TL_player.BringToFront();
            }
            
            
        }
        private void RestartGame()
        {
            
            TL_player.Image = Properties.Resources.up;

            foreach(PictureBox i in zombiesList)
            {
                this.Controls.Remove(i);
            }

            zombiesList.Clear();

            for(int i = 0;i < 3; i++)
            {
                MakeZombies();
            }
            // reset healthbar ammo etc
            goUp = false;
            goDown = false;
            goLeft = false;
            goRight = false;

            playerHealth = 100;
            score = 0;
            ammo = 10;
            gameOver = false;

            TL_lblEnd.Visible = false;
            TL_lblEndRestart.Visible = false;
            

            TL_gameTimer.Start();

        }

    }
}
