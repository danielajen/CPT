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
    public partial class Form4 : Form
    {
        bool lock1, lock2, lock3;
        public Form4()
        {
            InitializeComponent();
            lock1 = l1;
            lock2 = l2;
            lock3 = l3;
        }


        private void button2_Click(object sender, EventArgs e)
        {
            

            string answer = textBox1.Text.ToLower();
            int age = int.Parse(textBox2.Text);
            // answer
            if (answer == "adidas" && age >= 10)
            {
                Form6 main = new Form6();
                main.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Wrong answers! Check The instructions for any help! You either don't know fashion or are too young. Try again");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is a drip generator customizer where you can customize your drip to the max! Must be older than 10 to play! Hint for Login: 'it starts with an a' ");
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
