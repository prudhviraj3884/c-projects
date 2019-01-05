using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace studentfeedbacksystem

{
    public partial class student : Form
    {
        
        public student()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            SqlConnection s = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\c#prudhvi\prudhviraj3884\c-projects\studentfeedbacksystem\studentfeedbacksystem\Database143.mdf;Integrated Security=True");
            string query = "select * from table145 where studentid='" + studentusername.Text.Trim() + "' and studentname='" + studentpassword.Text.Trim() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, s);
            DataTable dt1 = new DataTable();
            sda.Fill(dt1);
            if(dt1.Rows.Count==1)
            {
                studentfeed sd = new studentfeed();
                this.Hide();
                sd.Show();

            }
            else
            {
                MessageBox.Show("invalid username or password");
            }



        }
    }
}
