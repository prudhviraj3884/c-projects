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
    public partial class faculty : Form
    {
        public faculty()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection s = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\c#prudhvi\prudhviraj3884\c-projects\studentfeedbacksystem\studentfeedbacksystem\Database143.mdf;Integrated Security=True");
            string query = "select * from table99 where facultyid='" + facultyusername.Text.Trim() + "' and facultyname='" + facultypassword.Text.Trim() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, s);
            DataTable dt1 = new DataTable();
            sda.Fill(dt1);
            if (dt1.Rows.Count == 1)
            {
                facultyfeed1 sd = new facultyfeed1();
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
