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
        #region Field

        private float posX = 0;
        private float posY = 0;

        private Graphics graphic;


        #endregion

        public Form1()
        {
            InitializeComponent();

            posX = drawingPanel.Width / 2;
            posY = drawingPanel.Height / 2;

            graphic = drawingPanel.CreateGraphics();
            graphic.DrawRectangle(new Pen(Color.Red), 10, 10, 100, 200);

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

        private void ChangeCombobox1(object sender, EventArgs e)
        {
            MessageBox.Show(comboBox1.SelectedItem.ToString()); 
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            graphic.DrawLine(new Pen(Color.Red), posX, posY, posX, posY - 5);
            posY -= 5;
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            graphic.DrawLine(new Pen(Color.Red), posX, posY, posX, posY + 5);
            posY += 5;
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            graphic.DrawLine(new Pen(Color.Red), posX, posY, posX + 5, posY );
            posX += 5;
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            graphic.DrawLine(new Pen(Color.Red), posX, posY, posX - 5, posY);
            posX -= 5;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            graphic.Clear(Color.White);
        }
    }
}
