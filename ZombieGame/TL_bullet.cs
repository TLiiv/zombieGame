using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace ZombieGame
{
    internal class TL_bullet
    {
        public string direction;
        public int bulletLeft;
        public int bulletTop;
        
        private int speed = 20;
        private PictureBox bullet = new PictureBox();
        private Timer bulletTimer = new Timer();

        public void MakeBullet(Form form)
        {
            bullet.BackColor = Color.White;
            bullet.Size = new Size(5,5);
            bullet.Tag = "bullet";
            bullet.Top = bulletTop;
            bullet.Left = bulletLeft;
            bullet.BringToFront();

            form.Controls.Add(bullet); // add bullet to the form
            bulletTimer.Interval = speed;
            bulletTimer.Tick += new EventHandler(BulletTimerEvent);
            bulletTimer.Start();
        }

        private void BulletTimerEvent(object sender, EventArgs e)
        {
            if(direction == "left")
            {
                bullet.Left -= speed;
            }else if(direction == "right")
            {
                bullet.Left += speed;
            }else if (direction == "up")
            {
                bullet.Top -= speed;
            }else if(direction == "down")
            {
                bullet.Top += speed;
            }

            //bulleti kaotamine
            if(bullet.Left < 10 || bullet.Left > 910 || bullet.Top < 10 || bullet.Top > 690)
            {
                bulletTimer.Stop();
                bulletTimer.Dispose();
                bullet.Dispose();
                bulletTimer = null;
                bullet = null;
            }
        }
    }
}
