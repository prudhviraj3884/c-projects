using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace studentfeedbacksystem
{
    public partial class facultyfeed1 : Form
    {
        public facultyfeed1()
        {
            InitializeComponent();
        }

        private void facultyfeed1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database143DataSet2.table145' table. You can move, or remove it, as needed.
            this.table145TableAdapter.Fill(this.database143DataSet2.table145);
            // TODO: This line of code loads data into the 'database143DataSet1.table99' table. You can move, or remove it, as needed.
            this.table99TableAdapter.Fill(this.database143DataSet1.table99);

        }
    }
}
