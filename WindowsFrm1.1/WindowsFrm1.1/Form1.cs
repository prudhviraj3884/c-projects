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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void LOGIN_Click(object sender, EventArgs e)
        {
            Form2 g = new Form2();

            if (User.Text == "JAMES" && Password.Text == "faculty")
            {
                MessageBox.Show("ACCESS GRANTED");
                g.Show();
                User.Clear();
                Password.Clear();
            }
            else
                MessageBox.Show("ACCESS DENIED");

            User.Clear();
            Password.Clear();
          
            this.Hide();

            

        }

        private void RESULT_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

       

        private void RESULTBOX_TextChanged(object sender, EventArgs e)
        {

        }

        private void mychoice_Click(object sender, EventArgs e)
        {
           
            
              
        }

    }
}
