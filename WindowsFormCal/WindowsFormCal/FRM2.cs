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
    public partial class FRM2 : Form
    {
        string ch=" ";
      int s = 0, p = 1;
        public FRM2()
        {
            InitializeComponent();
        }

        private void buton1_Click(object sender, EventArgs e)
        {
            RESULTBOX.Text = ch + "1";
            ch = RESULTBOX.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RESULTBOX.Text = ch + "2";
            ch = RESULTBOX.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            RESULTBOX.Text = ch + "3";
            ch = RESULTBOX.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            RESULTBOX.Text = ch + "4";
            ch = RESULTBOX.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            RESULTBOX.Text = ch + "5";
            ch = RESULTBOX.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            RESULTBOX.Text = ch + "6";
            ch = RESULTBOX.Text;
        }

        private void Mul_Click(object sender, EventArgs e)
        {
            RESULTBOX.Text = ch + "*";
            ch = RESULTBOX.Text;
        }

        private void ADD_Click(object sender, EventArgs e)
        {
            RESULTBOX.Text = ch + "+";
            ch = RESULTBOX.Text;
        }

        private void SUBTRACT_Click(object sender, EventArgs e)
        {
            RESULTBOX.Text = ch + "-";
            ch = RESULTBOX.Text;
        }

        private void Div_Click(object sender, EventArgs e)
        {
            RESULTBOX.Text = ch + "/";
            ch = RESULTBOX.Text;
        }
        private void RESULTBOX_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void EQUALL_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < ch.Length; i++)
            {
                if (ch[i] =='+')
                {
                    
                    string[] st = ch.Split('+');
                    int[] inn = new int[st.Length];
                    for (int j = 0; j < st.Length; j++)
                    {
                        inn[j] = Convert.ToInt32(st[j]);
                    }
                    for (int k = 0; k < inn.Length; k++)
                    {
                        s = s + inn[k];
                    }
                    RESULTBOX.Text = Convert.ToString(s);
                    ch = RESULTBOX.Text;
                    s = 0;
                }
                
            }
            for (int i = 0; i < ch.Length; i++)
            {
                if (ch[i] == '-')
                {
                    string[] st = ch.Split('-');
                    int[] inn = new int[st.Length];
                   for(int j=0;j<st.Length;j++)
                    {
                        inn[j] = Convert.ToInt32(st[j]);
                    }
                    s = inn[0] - inn[1];
                    RESULTBOX.Text = Convert.ToString(s);
                    s = 0;
                    ch = RESULTBOX.Text;
                }
               

            }
            for (int i = 0; i < ch.Length; i++)
            {
                if (ch[i] == '*')
                {
                    string[] st = ch.Split('*');
                    int[] inn = new int[st.Length];
                    for (int j = 0; j < st.Length; j++)
                    {
                        inn[j] = Convert.ToInt32(st[j]);
                    }
                    for (int k = 0; k < inn.Length; k++)
                    {
                        p = p*inn[k];
                    }
                    RESULTBOX.Text = Convert.ToString(p);
                    
                    ch = RESULTBOX.Text;
                    p = 1;
                }
                
            }
            for (int i = 0; i < ch.Length; i++)
            {
                if (ch[i] == '/')
                {
                    string[] st = ch.Split('/');
                    int[] inn = new int[st.Length];
                    for (int j = 0; j < st.Length; j++)
                    {
                        inn[j] = Convert.ToInt32(st[j]);
                    }
                    p = inn[0] / inn[1];
                    RESULTBOX.Text = Convert.ToString(p);
                    p = 1;
                    ch = RESULTBOX.Text;
                }
                

            }
        }

        private void buttonn7_Click(object sender, EventArgs e)
        {
            RESULTBOX.Text = ch + "7";
            ch = RESULTBOX.Text;
        }

        private void buttonn8_Click(object sender, EventArgs e)
        {
            RESULTBOX.Text = ch + "8";
            ch = RESULTBOX.Text;
        }

        private void buttonn9_Click(object sender, EventArgs e)
        {
            RESULTBOX.Text = ch + "9";
            ch = RESULTBOX.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            RESULTBOX.Text = ch + "0";
            ch = RESULTBOX.Text;
        }

        private void CLEAR_Click(object sender, EventArgs e)
        {
            RESULTBOX.Clear();
            ch=" ";
        }

       
    }
}
