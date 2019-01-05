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
using System.IO;


namespace studentfeedbacksystem
{
    public partial class studentfeedbackform : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\c#prudhvi\prudhviraj3884\c-projects\studentfeedbacksystem\studentfeedbacksystem\Database143.mdf;Integrated Security=True");
        public studentfeedbackform()
        {
            InitializeComponent();
        }

        private void studentfeedbackform_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            studentfeed sd = new studentfeed();
            this.Close();
            sd.Show();
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            con.Open();
            int a = Convert.ToInt32(tb1.Text);
            int b = Convert.ToInt32(tb2.Text);
            int c = Convert.ToInt32(tb3.Text);
            int d = Convert.ToInt32(tb4.Text);
            int f = Convert.ToInt32(tb5.Text);
            int g = Convert.ToInt32(tb6.Text);
            int h = Convert.ToInt32(tb7.Text);
            int avg = (a + b + c + d + f + g + h) / 7;
            string rating="";
          if(avg==1)
            {
                rating = "poor";
            }
          else if(avg==2)
            {
                rating = "average";
            }
          else if(avg==3)
            {
                rating = "good";
            }
          else if(avg==4)
            {
                rating = "very good";
            }
          else if(avg==5)
            {
                rating = "excellent";
            }
            
            SqlCommand cmd1 = con.CreateCommand();
            cmd1.CommandType = CommandType.Text;
            cmd1.CommandText = "update  table99 set rating='"+rating+"' where facultyid='" + facultyidbox.Text + "'";
            cmd1.ExecuteNonQuery();
            MessageBox.Show("YOUR FEEDBACK YOU IS SUBMITTED SUCCESSFULLY THANK YOU");
            
            SqlCommand cmd2 = con.CreateCommand();
            cmd2.CommandType = CommandType.Text;
            cmd2.CommandText = "update table145 set facultyid='" + facultyidbox.Text + "' where studentid='" + studentidbox.Text + "'";
            cmd2.ExecuteNonQuery();
            
            SqlCommand cmd3 = con.CreateCommand();
            cmd3.CommandType = CommandType.Text;
            cmd3.CommandText = "update table145 set ratingsubmitted='"+rating+"' where studentid='" + studentidbox.Text + "'";
            cmd3.ExecuteNonQuery();
            MessageBox.Show("your feedback is recorded");
            con.Close();
           

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Close();
        }
    }
}
