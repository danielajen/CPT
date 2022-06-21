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
    
    public partial class Form1 : Form
    {bool l1 = false, l2 = false, l3 = false;
        public Form1(bool lock1, bool lock2, bool lock3)
        {
            InitializeComponent();
            l1 = lock1;
            l2 = lock2;
            l3 = lock3;
            if (l1 == true) pbLock1.Visible = false;
            if (l2 == true) pbLock2.Visible = false;
            if (l3 == true) pbLock3.Visible = false;


        }

        private void pbLock3_Click(object sender, EventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            pbLock1.Visible = false;
            l1 = true;
            MessageBox.Show("WELCOME!");
        }

        private void pbGame1_Click(object sender, EventArgs e)
        {
            Form2 game1 = new Form2(l1, l2, l3);
            game1.Show();
            this.Hide();

        }

        private void pbLock1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Please click start to begin Or click the next level.");
        }

        private void pbGame2_Click(object sender, EventArgs e)
        {
            Form3 Game2 = new Form3(l1, l2, l3);
            Game2.Show();
            this.Hide();


        }
    }
}
