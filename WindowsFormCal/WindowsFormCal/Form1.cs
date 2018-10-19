using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormCal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void LOGIN_Click(object sender, EventArgs e)
        {
            FRM2 f = new FRM2();
            if (User.Text == "prudhvi" && Password.Text == "2016cse257")
            {
                MessageBox.Show("ACCESS GRANTED");
                f.Show();
                this.Hide();
            }
           
                
            else
                MessageBox.Show("ACCESS DENIED");
           
                
        }
    }
}
