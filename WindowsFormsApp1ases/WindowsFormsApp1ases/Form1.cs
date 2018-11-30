using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1ases
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (TB1.Text == "raj" && TB2.Text == "2016cse257")
            {
                MessageBox.Show("LOGIN SUCCESSFUL");
                Form3 f = new Form3();
                f.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("INVALID USERNAME OR PASSWORD");
            }
        }
    }
}
