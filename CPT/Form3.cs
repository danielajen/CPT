using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CPT
{
    public partial class Form3 : Form
    {
        int lives = 3;
        bool lock1, lock2, lock3;
        public Form3(bool l1, bool l2, bool l3)
        {
            InitializeComponent();
            lock1 = l1;
            lock2 = l2;
            lock3 = l3;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome to Click It! Click start or rules.");
        }

        private void Bomb_Click(object sender, EventArgs e)
        {
            lblLives2.Text = lives.ToString();
            lives--;
            lblLives2.Text = "lives : " + lives;
            if (lives == 0)
            {
                MessageBox.Show("YOU LOSE, beat level 2 to proceed to level 3.");
                Form1 Start = new Form1(lock1, lock2, lock3);
                Start.Show();
                this.Hide();
            }
        }

        private void Right_Click(object sender, EventArgs e)
        {

        }

        private void Orange_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void btnStart2_Click(object sender, EventArgs e)
        {

        }

        private void btnRules2_Click(object sender, EventArgs e)
        {

        }
    }
}
