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

namespace WindowsFormsApp1ases
{
    public partial class Form3 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\c#prudhvi\prudhviraj3884\c-projects\WindowsFormsApp1ases\WindowsFormsApp1ases\Database1.0.mdf;Integrated Security=True;Connect Timeout=30");
        public Form3()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_Database1_0DataSet.Table1' table. You can move, or remove it, as needed.
            this.table1TableAdapter.Fill(this._Database1_0DataSet.Table1);

        }

        private void REGISTER_Click(object sender, EventArgs e)
        {
                con.Open();
                SqlCommand cmd1 = con.CreateCommand();
                cmd1.CommandType = CommandType.Text;
                cmd1.CommandText = "insert into Table1 values('" + ID.Text + "','" + name.Text + "','" + section.Text + "','" + branch.Text + "','" + DOB.Text + "')";
                cmd1.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("SUCCESSFULLY REGISTERED");


            
        }

        private void DISPLAY_Click(object sender, EventArgs e)
        {

            con.Open();
            SqlCommand cmd1 = con.CreateCommand();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Table1 WHERE Id='" + ID.Text + "'", con);
            DataSet ds = new DataSet();
            da.Fill(ds, "Table1");
            dataGridView1.DataSource = ds.Tables["Table1"].DefaultView;
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd1 = con.CreateCommand();
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Table1 ", con);
            DataSet ds = new DataSet();
            da.Fill(ds, "Table1");
            dataGridView1.DataSource = ds.Tables["Table1"].DefaultView;
            con.Close();
        }
    }
}
