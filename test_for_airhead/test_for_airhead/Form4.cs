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
    public partial class Form4 : Form
    {
        public int mark;
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            Form1 form1 = Application.OpenForms.OfType<Form1>().Single();
            label2.Text = form1.surname + " " + form1.name + " " + form1.eschoname + " гр. " + form1.groupname;
            Form3 form3 = Application.OpenForms.OfType<Form3>().Single();
            label3.Text = "Результат : " + form3.result + "/15";
            if(form3.result <= 5)
            {
                mark = 2;
            }else if(form3.result > 5 && form3.result <= 10)
            {
                mark = 3;
            }else if (form3.result > 10 && form3.result <= 13)
            {
                mark = 4;
            }else if (form3.result > 13)
            {
                mark = 5;
            }
            label4.Text = "Оценка :" + mark;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
