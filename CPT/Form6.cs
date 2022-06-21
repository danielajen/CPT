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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            Form8 main = new Form8();
            main.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form8 main = new Form8();
            main.Show();
            this.Hide();
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form7 main = new Form7();
            main.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Form7 main = new Form7();
            main.Show();
            this.Hide();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome, please choose a category to design!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 main = new Form4();
            main.Show();
            this.Hide();
        }
    }
}
