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
    public partial class Form8 : Form
    {
        Random box = new Random();
        int number = 0;
        int score = 0;
        public Form8()
        {
            InitializeComponent();
        }

        private void lr_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbye.SelectedIndex == 0)
            {
                lr.Visible = true;
                score = score + 1;
                heartbreak.Visible = false;
                yeezus.Visible = false;
                ye.Visible = false;
                college.Visible = false;

            }
            else if (cbye.SelectedIndex == 1)
            {
                heartbreak.Visible = true;
                score = score + 1;
                lr.Visible = false;
                yeezus.Visible = false;
                ye.Visible = false;
                college.Visible = false;
            }
            else if (cbye.SelectedIndex == 2)
            {
                yeezus.Visible = true;
                score = score + 1;
                lr.Visible = false;
                heartbreak.Visible = false;
                ye.Visible = false;
                college.Visible = false;
            }
            else if (cbye.SelectedIndex == 3)
            {
                ye.Visible = true;
                score = score + 1;
                lr.Visible = false;
                heartbreak.Visible = false;
                yeezus.Visible = false;
                college.Visible = false;
            }
            else if (cbye.SelectedIndex == 4)

            {
                college.Visible = true;
                score = score + 1;
                lr.Visible = false;
                heartbreak.Visible = false;
                yeezus.Visible = false;
                ye.Visible = false;
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbdesign.SelectedIndex == 0)
            {
                prada.Visible = true;
                score = score + 1;
                gucci.Visible = false;
                cdg.Visible = false;

            }
            else if (cbdesign.SelectedIndex == 1)
            {
                cdg.Visible = true;
                score = score + 1;
                gucci.Visible = false;
                prada.Visible = false;
            }
            else if (cbdesign.SelectedIndex == 2)
            {
                gucci.Visible = true;
                score = score + 1;
                cdg.Visible = false;
                prada.Visible = false;

            }
        }

        private void Form8_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int number = box.Next(1, 3);

            if (number == 1) pictureBox1.BackgroundImage = Properties.Resources.download__3___1_;
            if (number == 2) pictureBox1.BackgroundImage = Properties.Resources.download__2_;
            if (number == 3) pictureBox1.BackgroundImage = Properties.Resources.download__1_;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "Change Shirt")
            {
                timer1.Start();
                button1.Text = "STOP";
                score = score + 10;
            }
            else
            {
                timer1.Stop();
                button1.Text = "Change Shirt";
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("", "Wanna customize other stuff?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Form6 main = new Form6();
                main.Show();
                this.Hide();
            }
            else if (MessageBox.Show("", "Wanna customize other stuff?", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                MessageBox.Show("bye then, hope you had fun!");
                this.Close();
            }
        }
    }
}