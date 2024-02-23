using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentsGradeApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            double English, Math, Science, Filipino, History;
            string name = textBox1.Text;

            English = Convert.ToDouble(textBox3.Text);
            Math = Convert.ToDouble(textBox4.Text);
            Science = Convert.ToDouble(textBox5.Text);
            Filipino = Convert.ToDouble(textBox6.Text);
            History = Convert.ToDouble(textBox7.Text);

            double total = English + Math + Science + Filipino + History;
            double average = total / 5;

            label9.Text = (average >= 75.00) ? " The student is passed " : " The student is failed";
            label10.Text = " The general average of " + name + " is " + average;
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
