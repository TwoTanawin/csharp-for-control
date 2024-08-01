using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace changeFormColor
{
    public partial class Form2 : Form
    {
        private bool isGreen;
        public Form2()
        {
            InitializeComponent();
            isGreen = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isGreen)
            {
                this.BackColor = Color.Red;
                MyColor.Text = "I' am Green";
            }
            else
            {
                this .BackColor = Color.Green;
                MyColor.Text = "I' am Red";
            }
            isGreen = !isGreen;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
