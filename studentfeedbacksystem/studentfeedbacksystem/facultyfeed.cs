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
    public partial class facultyfeed : Form
    {
        public facultyfeed()
        {
            InitializeComponent();
        }

        private void facultyfeed_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database143DataSet.table99' table. You can move, or remove it, as needed.
            this.table99TableAdapter.Fill(this.database143DataSet.table99);

        }
    }
}
