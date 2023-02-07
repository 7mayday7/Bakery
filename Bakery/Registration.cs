using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bakery
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.UseSystemPasswordChar = false;
            pictureBox1_Close.Visible = false;
            pictureBox3_Open.Visible = true;
        }

        private void pictureBox3_Open_Click(object sender, EventArgs e)
        {
            textBox2.UseSystemPasswordChar = true;
            pictureBox1_Close.Visible = true;
            pictureBox3_Open.Visible = false;
        }

        private void pictureBox2_Close_Click(object sender, EventArgs e)
        {
            textBox2.UseSystemPasswordChar = false;
            pictureBox1_Close.Visible = false;
            pictureBox3_Open.Visible = true;
        }

        private void pictureBox4_Open_Click(object sender, EventArgs e)
        {
            textBox2.UseSystemPasswordChar = false;
            pictureBox1_Close.Visible = false;
            pictureBox3_Open.Visible = true;
        }
    }
}
