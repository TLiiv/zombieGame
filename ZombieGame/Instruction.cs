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
    public partial class Instruction : Form
    {
        public Instruction()
        {
            InitializeComponent();
        }

        

        private void TL_btnStartGame_Click(object sender, EventArgs e)
        {
            Form Game = new TL_ZombieGameForm();
            Game.Visible = true;
            Game.Activate();
            TL_btnStartGame.Enabled = false;
        }
    }
}
