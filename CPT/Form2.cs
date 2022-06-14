using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace CPT
{
    public partial class Form2 : Form
    {
        int lives = 3;
        bool lock1, lock2, lock3;
        public Form2(bool l1, bool l2, bool l3)
        {
            InitializeComponent();
            lock1 = l1;
            lock2 = l2;
            lock3 = l3;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnRules1_Click(object sender, EventArgs e)
        {
            RULES1 Rules = new RULES1();
            Rules.Show();
            this.Hide();
        }

        private void btnStart1_Click(object sender, EventArgs e)
        {
            pbB1.Location = new Point(253, 12);
            for (int y = 5; y < 340; y = y + 5)
            {
                pbB1.Location = new Point(253, y);
                this.Update();
                Thread.Sleep(50);
            }
            pbB2.Location = new Point(334, 12);
            for (int y = 5; y < 340; y = y + 5)
            {
                pbB2.Location = new Point(334, y);
                this.Update();
                Thread.Sleep(50);
            }
            pbB3.Location = new Point(411, 12);
            for (int y = 5; y < 340; y = y + 5)
            {
                pbB3.Location = new Point(411, y);
                this.Update();
                Thread.Sleep(50);
            }
            pbB4.Location = new Point(288, 392);
            for (int y = 5; y < 340; y = y - 5)
            {
                pbB4.Location = new Point(288, y);
                this.Update();
                Thread.Sleep(50);
            }
        }

        private void bombs1(object sender, EventArgs e)
        {
            lblLives1.Text = lives.ToString();
            lives--;
            lblLives1.Text = "lives : " + lives;
            if (lives == 0)
            {
                MessageBox.Show("YOU LOSE, beat level 1 to proceed to level 2.");
                Form1 Start = new Form1(lock1, lock2, lock3);
                Start.Show();
                this.Hide();
            }
          
        }

        private void btnFinish1_Click(object sender, EventArgs e)
        {
            lock2 = true;
            Form1 Start = new Form1(lock1, lock2,lock3);
            Start.Show();
            this.Hide();
        }
    }
}
