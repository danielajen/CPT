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

        private void btnStart1_Click(object sender, EventArgs e)
        {
           timer1.Start();
           timer2.Start();
           timer3.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pbB1.Location = new Point(pbB1.Location.X, pbB1.Location.Y + 5);
            if (pbB1.Location.Y > 450) pbB1.Location = new Point(pbB1.Location.X, -10);
            pbB3.Location = new Point(pbB3.Location.X, pbB3.Location.Y + 5);
            if (pbB3.Location.Y > 450) pbB3.Location = new Point(pbB3.Location.X, -10);
            pbB5.Location = new Point(pbB5.Location.X, pbB5.Location.Y - 5);
            if (pbB5.Location.Y < -50) pbB5.Location = new Point(pbB5.Location.X, 380);
            pbB6.Location = new Point(pbB6.Location.X, pbB6.Location.Y + 5);
            if (pbB6.Location.Y > 450) pbB6.Location = new Point(pbB6.Location.X, -10);
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            pbB2.Location = new Point(pbB2.Location.X, pbB2.Location.Y + 5);
            if (pbB2.Location.Y > 450) pbB2.Location = new Point(pbB2.Location.X, -10);
            pbB4.Location = new Point(pbB4.Location.X, pbB4.Location.Y - 5);
            if (pbB4.Location.Y < -50) pbB4.Location = new Point(pbB4.Location.X, 380); 
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            pbB7.Location = new Point(pbB7.Location.X, pbB7.Location.Y + 5);
            if (pbB7.Location.Y > 450) pbB7.Location = new Point(pbB7.Location.X, -10);
            pbB8.Location = new Point(pbB8.Location.X, pbB8.Location.Y - 5);
            if (pbB8.Location.Y < -50) pbB8.Location = new Point(pbB8.Location.X, 380);
        }

        private void Side_Enter(object sender, EventArgs e)
        {
            Point startingPoint = panel1.Location;
            startingPoint.Offset(27, 211);
            Cursor.Position = PointToScreen(startingPoint);
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
            Form1 Start = new Form1(lock1, lock2, lock3);
            Start.Show();
            this.Hide();
        }
    }
}
