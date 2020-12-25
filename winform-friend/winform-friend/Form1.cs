using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winform_friend
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

      


       

        private void UpdateLabel1(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            {
                label1.Text = "ItemChecked";
            }
            else
            {
                label1.Text = "Item Un-Checked";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(radioButton1.Checked)
            {
                panel1.BackColor = Color.Red;
            }
            else if (radioButton2.Checked)
            {
                panel1.BackColor = Color.Green;
            }
            else
            {
                panel1.BackColor = Color.Blue;
            }
        }

        
    }
}
