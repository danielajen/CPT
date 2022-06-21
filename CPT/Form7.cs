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
    public partial class Form7 : Form
    {
        Random box = new Random();
        int num = 0;
        int score = 0;

        string jerseyname;
        public Form7()
        {
            InitializeComponent();
        }

        private void bayern_Click(object sender, EventArgs e)
        {

        }

        private void cblogo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cblogo.SelectedIndex == 2)
            {
                bayern.Visible = true;
                score = score + 1;
                fcb.Visible = false;
                canmnt.Visible = false;
                tfc.Visible = false;
                real.Visible = false;

            }
            else if (cblogo.SelectedIndex == 0)
            {
                fcb.Visible = true;
                score = score + 1;
                bayern.Visible = false;
                canmnt.Visible = false;
                tfc.Visible = false;
                real.Visible = false;
            }
            else if (cblogo.SelectedIndex == 1)
            {
                canmnt.Visible = true;
                score = score + 1;
                fcb.Visible = false;
                bayern.Visible = false;
                tfc.Visible = false;
                real.Visible = false;
            }
            else if (cblogo.SelectedIndex == 3)
            {
                tfc.Visible = true;
                score = score + 1;
                canmnt.Visible = false;
                fcb.Visible = false;
                bayern.Visible = false;
                real.Visible = false;
            }
            else if (cblogo.SelectedIndex == 4)
               
            {
                real.Visible = true;
                score = score + 1;
                canmnt.Visible = false;
                fcb.Visible = false;
                bayern.Visible = false;
                tfc.Visible = false;
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (colour.SelectedIndex == 0)
            {
                jersey.BackColor = Color.Blue;
                score = score + 1;
            }
            else if (colour.SelectedIndex == 1)
            {
                jersey.BackColor = Color.Red;
                score = score + 1;
            }
            else if (colour.SelectedIndex == 2)
            {
                jersey.BackColor = Color.Yellow;
                score = score + 1;
            }
            else if (colour.SelectedIndex == 3)
            {
                jersey.BackColor = Color.Pink;
                score = score + 1;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // submit name
            jerseyname = textBox1.Text;
            label7.Text = jerseyname;
            label8.Visible = true;
            colour2.Visible = true;

        }

        private void comboBox2_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (colour2.SelectedIndex == 0)
            {
                label7.ForeColor = Color.Orange;
                score = score + 1;
            }
            else if (colour2.SelectedIndex == 1)
            {
                label7.ForeColor = Color.Teal;
                score = score + 1;
            }
            else if (colour2.SelectedIndex == 2)
            {
                label7.ForeColor = Color.Green;
                score = score + 1;
            }
            else if (colour2.SelectedIndex == 3)
            {
                label7.ForeColor = Color.Purple;
                score = score + 1;
            }
        }

        private void sponsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (sponsers.SelectedIndex == 0)
            {
                bell.Visible = true;
                score = score + 1;
                td.Visible = false;
                meta.Visible = false;
                micro.Visible = false;
                rogers.Visible = false;

            }
            else if (sponsers.SelectedIndex == 1)
            {
                td.Visible = true;
                score = score + 1;
                bell.Visible = false;
                meta.Visible = false;
                micro.Visible = false;
                rogers.Visible = false;
            }
            else if (sponsers.SelectedIndex == 2)
            {
                meta.Visible = true;
                score = score + 1;
                td.Visible = false;
                bell.Visible = false;
                micro.Visible = false;
                rogers.Visible = false;
            }
            else if (sponsers.SelectedIndex == 3)
            {
                micro.Visible = true;
                score = score + 1;
                meta.Visible = false;
                td.Visible = false;
                bell.Visible = false;
                rogers.Visible = false;
            }
            else if (sponsers.SelectedIndex == 4)
            {
                rogers.Visible = true;
                score = score + 1;
                meta.Visible = false;
                td.Visible = false;
                bell.Visible = false;
                micro.Visible = false;
            }

        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            score = score + 1;
            num = box.Next(1, 51);
            label9.Text = num.ToString();
            if (score == 5)
            {
                MessageBox.Show("sorry, you're only allowed to generate 5 different jersey numbers, it's very limited edition... you're stuck with this number now");
                label2.Visible = false;
                button3.Visible = false;
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (score <= 6)
            {
                MessageBox.Show("add sum more customizations! your jersey is way too bland! Change it up a bit!");
            }
            else if (score >=7)
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

        private void micro_Click(object sender, EventArgs e)
        {

        }

        private void td_Click(object sender, EventArgs e)
        {

        }
    }
}
