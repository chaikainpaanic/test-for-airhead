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
    public partial class Form3 : Form
    {
        public int result;
        public Form3()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!radioButton1.Checked && !radioButton2.Checked && !radioButton3.Checked && !radioButton4.Checked)
            {
                MessageBox.Show("Выбирите ответ");
            }
            else
            {
                radioButton1.Enabled = false;
                radioButton2.Enabled = false;
                radioButton3.Enabled = false;
                radioButton4.Enabled = false;
                button1.Visible = false;
                if (radioButton3.Checked){result++;}
                tabControl1.SelectedIndex++;
                CheckAll();
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!radioButton5.Checked && !radioButton6.Checked && !radioButton7.Checked && !radioButton8.Checked)
            {
                MessageBox.Show("Выбирите ответ");
            }
            else
            {
                radioButton5.Enabled = false;
                radioButton6.Enabled = false;
                radioButton7.Enabled = false;
                radioButton8.Enabled = false;
                button2.Visible = false;
                if (radioButton6.Checked) { result++; }
                tabControl1.SelectedIndex++;
                CheckAll();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
            
        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton22_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void CheckAll()
        {
            if (!button1.Visible && !button2.Visible && !button4.Visible && 
                !button5.Visible && !button6.Visible && !button7.Visible && 
                !button8.Visible && !button9.Visible && !button10.Visible &&
                !button11.Visible && !button12.Visible && !button13.Visible &&
                !button14.Visible && !button15.Visible && !button16.Visible)
            {
                Form4 Form4 = new Form4();
                Form4.Show();
                this.Hide();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (!radioButton9.Checked && 
                !radioButton10.Checked && 
                !radioButton11.Checked && 
                !radioButton12.Checked)
            {
                MessageBox.Show("Выбирите ответ");
            }
            else
            {
                radioButton9.Enabled = false;
                radioButton10.Enabled = false;
                radioButton11.Enabled = false;
                radioButton12.Enabled = false;
                button4.Visible = false;
                if (radioButton11.Checked) { result++; }
                tabControl1.SelectedIndex++;
                CheckAll();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (!radioButton13.Checked &&
                !radioButton14.Checked &&
                !radioButton15.Checked)
            {
                MessageBox.Show("Выбирите ответ");
            }
            else
            {
                radioButton13.Enabled = false;
                radioButton14.Enabled = false;
                radioButton15.Enabled = false;
                button5.Visible = false;
                if (radioButton13.Checked) { result++; }
                tabControl1.SelectedIndex++;
                CheckAll();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (!radioButton16.Checked &&
                !radioButton17.Checked &&
                !radioButton18.Checked &&
                !radioButton19.Checked)
            {
                MessageBox.Show("Выбирите ответ");
            }
            else
            {
                radioButton16.Enabled = false;
                radioButton17.Enabled = false;
                radioButton18.Enabled = false;
                radioButton19.Enabled = false;
                button6.Visible = false;
                if (radioButton18.Checked) { result++; }
                tabControl1.SelectedIndex++;
                CheckAll();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (!radioButton20.Checked &&
                !radioButton21.Checked)
            {
                MessageBox.Show("Выбирите ответ");
            }
            else
            {
                radioButton20.Enabled = false;
                radioButton21.Enabled = false;
                button7.Visible = false;
                if (radioButton20.Checked) { result++; }
                tabControl1.SelectedIndex++;
                CheckAll();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (!radioButton22.Checked &&
                !radioButton23.Checked &&
                !radioButton24.Checked &&
                !radioButton25.Checked)
            {
                MessageBox.Show("Выбирите ответ");
            }
            else
            {
                radioButton22.Enabled = false;
                radioButton23.Enabled = false;
                radioButton24.Enabled = false;
                radioButton25.Enabled = false;
                if (radioButton23.Checked) { result++; }
                button8.Visible = false;
                tabControl1.SelectedIndex++;
                CheckAll();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (!radioButton26.Checked &&
                !radioButton27.Checked &&
                !radioButton28.Checked &&
                !radioButton29.Checked)
            {
                MessageBox.Show("Выбирите ответ");
            }
            else
            {
                radioButton26.Enabled = false;
                radioButton27.Enabled = false;
                radioButton28.Enabled = false;
                radioButton29.Enabled = false;
                if (radioButton27.Checked) { result++; }
                button9.Visible = false;
                tabControl1.SelectedIndex++;
                CheckAll();
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (!radioButton30.Checked &&
                !radioButton31.Checked &&
                !radioButton32.Checked &&
                !radioButton33.Checked)
            {
                MessageBox.Show("Выбирите ответ");
            }
            else
            {
                radioButton30.Enabled = false;
                radioButton31.Enabled = false;
                radioButton32.Enabled = false;
                radioButton33.Enabled = false;
                button10.Visible = false;
                if (radioButton31.Checked) { result++; }
                tabControl1.SelectedIndex++;
                CheckAll();
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (!radioButton34.Checked &&
                !radioButton35.Checked &&
                !radioButton36.Checked &&
                !radioButton37.Checked)
            {
                MessageBox.Show("Выбирите ответ");
            }
            else
            {
                radioButton34.Enabled = false;
                radioButton35.Enabled = false;
                radioButton36.Enabled = false;
                radioButton37.Enabled = false;
                if (radioButton36.Checked) { result++; }
                button11.Visible = false;
                tabControl1.SelectedIndex++;
                CheckAll();
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (!radioButton38.Checked &&
                !radioButton39.Checked &&
                !radioButton40.Checked &&
                !radioButton41.Checked)
            {
                MessageBox.Show("Выбирите ответ");
            }
            else
            {
                radioButton38.Enabled = false;
                radioButton39.Enabled = false;
                radioButton40.Enabled = false;
                radioButton41.Enabled = false;
                if (radioButton38.Checked) { result++; }
                button12.Visible = false;
                tabControl1.SelectedIndex++;
                CheckAll();
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (!radioButton42.Checked &&
                !radioButton43.Checked)
            {
                MessageBox.Show("Выбирите ответ");
            }
            else
            {
                radioButton42.Enabled = false;
                radioButton43.Enabled = false;
                if (radioButton42.Checked) { result++; }
                button13.Visible = false;
                tabControl1.SelectedIndex++;
                CheckAll();
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (!radioButton44.Checked &&
                !radioButton45.Checked &&
                !radioButton46.Checked &&
                !radioButton47.Checked)
            {
                MessageBox.Show("Выбирите ответ");
            }
            else
            {
                radioButton44.Enabled = false;
                radioButton45.Enabled = false;
                radioButton46.Enabled = false;
                radioButton47.Enabled = false;
                if (radioButton47.Checked) { result++; }
                button14.Visible = false;
                tabControl1.SelectedIndex++;
                CheckAll();
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (!radioButton48.Checked &&
                !radioButton49.Checked &&
                !radioButton50.Checked &&
                !radioButton51.Checked)
            {
                MessageBox.Show("Выбирите ответ");
            }
            else
            {
                radioButton48.Enabled = false;
                radioButton49.Enabled = false;
                radioButton50.Enabled = false;
                radioButton51.Enabled = false;
                if (radioButton50.Checked) { result++; }
                button15.Visible = false;
                tabControl1.SelectedIndex++;
                CheckAll();
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (!radioButton52.Checked &&
                !radioButton53.Checked &&
                !radioButton54.Checked &&
                !radioButton55.Checked)
            {
                MessageBox.Show("Выбирите ответ");
            }
            else
            {
                radioButton52.Enabled = false;
                radioButton53.Enabled = false;
                radioButton54.Enabled = false;
                radioButton55.Enabled = false;
                button16.Visible = false;
                if (radioButton54.Checked) { result++; }
                tabControl1.SelectedIndex++;
                CheckAll();
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
