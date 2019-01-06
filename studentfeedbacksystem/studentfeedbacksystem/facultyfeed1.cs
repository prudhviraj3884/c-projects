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
    public partial class facultyfeed1 : Form
    {
        SqlConnection hh = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\c#prudhvi\prudhviraj3884\c-projects\studentfeedbacksystem\studentfeedbacksystem\Database143.mdf;Integrated Security=True");
        public facultyfeed1()
        {
            InitializeComponent();
        }

        private void facultyfeed1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database143DataSet5.table145' table. You can move, or remove it, as needed.
            this.table145TableAdapter1.Fill(this.database143DataSet5.table145);
            // TODO: This line of code loads data into the 'database143DataSet4.table99' table. You can move, or remove it, as needed.
            this.table99TableAdapter1.Fill(this.database143DataSet4.table99);
            // TODO: This line of code loads data into the 'database143DataSet2.table145' table. You can move, or remove it, as needed.
            this.table145TableAdapter.Fill(this.database143DataSet2.table145);
            // TODO: This line of code loads data into the 'database143DataSet1.table99' table. You can move, or remove it, as needed.
            this.table99TableAdapter.Fill(this.database143DataSet1.table99);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            hh.Open();
            SqlDataAdapter myda = new SqlDataAdapter();
            string selectall = "select * from table145";
            myda.SelectCommand = new SqlCommand(selectall, hh);
            DataTable tb = new DataTable();
            myda.Fill(tb);
            BindingSource bsource = new BindingSource();
            bsource.DataSource = tb;
            dataGridView2.DataSource = bsource;
            hh.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
       
                hh.Open();
                SqlDataAdapter myda = new SqlDataAdapter();
                string selectall = "select * from table99";
                myda.SelectCommand = new SqlCommand(selectall, hh);
                DataTable tb = new DataTable();
                myda.Fill(tb);
                BindingSource bsource = new BindingSource();
                bsource.DataSource = tb;
                dataGridView1.DataSource = bsource;
                hh.Close();
                  
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
