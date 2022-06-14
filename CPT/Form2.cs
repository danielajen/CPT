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
