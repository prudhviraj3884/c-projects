using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFrm1._1
{
    
    public partial class Form2 : Form
    {
        string ch = "";
        public Form2()
        {
            InitializeComponent();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            
            
            this.Close();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void clear_Click(object sender, EventArgs e)
        {

        }

        private void buton1_Click(object sender, EventArgs e)
        {
            
            
            NUM1.Text = ch + "1";
            ch = NUM1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //int y;
            //y = 2;
            NUM1.Text =ch + "2";
            ch = NUM1.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            NUM1.Text = "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            NUM1.Text = "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            NUM1.Text = "5";
        }

        private void ADD_Click(object sender, EventArgs e)
        {
            NUM1.Text = ch + "+";
            ch = NUM1.Text;



        }

        private void SUBTRACT_Click(object sender, EventArgs e)
        {
            NUM1.Text = "-";
        }

        private void Mul_Click(object sender, EventArgs e)
        {
            NUM1.Text = "*";

        }

        private void Div_Click(object sender, EventArgs e)
        {
            //NUM1.Text = "/";
            int num1 = Convert.ToInt32(ch.Substring(0, 1));
            int num2 = Convert.ToInt32(ch.Substring(2, 1));
            NUM1.Text = Convert.ToString(num1 + num2);
        }
    }
}
