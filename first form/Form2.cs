using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace first_form
{
    public partial class Form2 : Form
    {

        public Form2()
        {
            InitializeComponent();
            textBox2.Text = Form1.Student_Name;
            textBox3.Text = Form1.Roll_;
            textBox4.Text = Form1.Reg_Id;
            textBox5.Text = Form1.Semester_;
            textBox6.Text = Form1.Blood_Group_;
            textBox7.Text = Form1.Gender_;

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
