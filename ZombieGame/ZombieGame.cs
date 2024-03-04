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
