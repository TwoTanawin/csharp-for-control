using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace math_operation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void minusOP_CheckedChanged(object sender, EventArgs e)
        {

        }

        private float plusOpFnc(float num1, float num2)
        {
            return num1 + num2;
        }

        private float minusOpFnc(float num1, float num2)
        {
            return num1 - num2;
        }

        private float mulOpFnc(float num1, float num2)
        {
            return num1 * num2;
        }

        private float divOpFnc(float num1, float num2)
        {
            return num1 / num2;
        }


        private void computeBtn_Click(object sender, EventArgs e)
        {
            float result = 0;
            try
            {
                if (plusOP.Checked == true)
                {
                    result = plusOpFnc(Convert.ToSingle(inputNum1.Text), (Convert.ToSingle(inputNum2.Text)));
                    outputNum.Text = result.ToString();
                }
                else if (minusOP.Checked == true)
                {
                    result = minusOpFnc(Convert.ToSingle(inputNum1.Text), (Convert.ToSingle(inputNum2.Text)));
                    outputNum.Text = result.ToString();
                }
                else if (mulOP.Checked == true)
                {
                    result = mulOpFnc(Convert.ToSingle(inputNum1.Text), (Convert.ToSingle(inputNum2.Text)));
                    outputNum.Text = result.ToString();
                }
                else if (divOP.Checked == true)
                {
                    if(inputNum2.Text == "0" || inputNum2.Text == "")
                    {
                        MessageBox.Show("The system cannot divide by Zero");
                    }
                    else
                    {
                        result = divOpFnc(Convert.ToSingle(inputNum1.Text), (Convert.ToSingle(inputNum2.Text)));
                        outputNum.Text = result.ToString();
                    }

                }
                else
                {
                    string msg = "Please Select Math Operations";
                    MessageBox.Show(msg);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
    }
}
