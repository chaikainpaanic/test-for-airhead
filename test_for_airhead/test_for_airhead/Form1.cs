using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test_for_airhead
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.BringToFront();
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.ForeColor = Color.WhiteSmoke;
            button1.BackColor = Color.FromArgb(218,78,91);
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.ForeColor = Color.FromArgb(218, 78, 91);
            button1.BackColor = Color.FromArgb(49,52,57);
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            button2.ForeColor = Color.WhiteSmoke;
            button2.BackColor = Color.FromArgb(218, 78, 91);
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.ForeColor = Color.FromArgb(218, 78, 91);
            button2.BackColor = Color.FromArgb(49, 52, 57);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
