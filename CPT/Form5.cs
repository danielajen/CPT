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
    public partial class RULES1 : Form
    {
        public RULES1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 game1 = new Form2(true,true, false);
            game1.Show();
            this.Hide();
        }
    }
}
