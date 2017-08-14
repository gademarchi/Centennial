using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Name: Gabriel De Marchi - 300930749
 * Date:13/08/2017
 * Description: Create form1 BMI Calculator.
 * Version: 0.6 - add a color in the label for show the result.
 * GitHub: https://github.com/gademarchi/Centennial/tree/master/Assignment_BMICalculator
 */


namespace Assignment_BMICalculator
{
    public partial class BMICalculator : Form
    {
        public BMICalculator()
        {
            InitializeComponent();
        }

        double m, kg, lb, inch, bmi;
        string target = "https://github.com/gademarchi/Centennial/tree/master/Assignment_BMICalculator";

        private void rdImperial_CheckedChanged(object sender, EventArgs e)
        {
            txtHeight.Text = "Inches";
            txtWeight.Text = "Pounds";

        }

        private void txtHeight_MouseClick(object sender, MouseEventArgs e)
        {
            txtHeight.Text = "";

         }

        private void txtWeight_MouseClick(object sender, MouseEventArgs e)
        {
            txtWeight.Text = "";
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
           System.Diagnostics.Process.Start(target);
        }

        private void rdMetric_CheckedChanged(object sender, EventArgs e)
        {
            txtHeight.Text = "Meters";
            txtWeight.Text = "Kg";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtHeight.Clear();
            txtWeight.Clear();
            txtBMI.Clear();
            txtResult.Text = " ";
            txtBMI.BackColor = Color.White;

        }

        string result;

        private void CalculateBMIButton_Click(object sender, EventArgs e)
        {
            if (rdImperial.Checked ==  true)
            {
        
                try
                {
                    lb = Convert.ToDouble(txtWeight.Text);
                    inch = Convert.ToDouble(txtHeight.Text);
                }
                catch { MessageBox.Show("Invalid value!"); }

                bmi = lb * 703 / Math.Pow(inch, 2);

                if(bmi < 18.5)
                {
                    result = "Underweight";
                    txtBMI.BackColor = Color.Red;
                    txtResult.BackColor = Color.Red;
                }

                else if(bmi <= 24.9)
                {
                    result = "Normal weight";
                    txtBMI.BackColor = Color.Green;
                    txtResult.BackColor = Color.Green;
                }

                else if(bmi <= 29.9)
                {
                    result = "Overweight";
                    txtBMI.BackColor = Color.Orange;
                    txtResult.BackColor = Color.Orange;
                }

                else if (bmi > 30)
                {
                    result = "Obese";
                    txtBMI.BackColor = Color.Red;
                    txtResult.BackColor = Color.Red;
                }
                else
                {
                    MessageBox.Show("ERROR");
                }

                txtBMI.Text = bmi.ToString("#.##");
                txtResult.Text = result;

            }
            else if(rdMetric.Checked == true)
            {


                try
                {
                    m = Convert.ToDouble(txtHeight.Text);
                    kg = Convert.ToDouble(txtWeight.Text);


                }
                catch { MessageBox.Show("Invalid value"); }

                bmi = kg / Math.Pow(m, 2);

                if (bmi < 18.5)
                {
                    result = "Underweight";
                    txtBMI.BackColor = Color.Red;
                    txtResult.BackColor = Color.Red;
                }

                else if (bmi <= 24.9)
                {
                    result = "Normal weight";
                    txtBMI.BackColor = Color.Green;
                    txtResult.BackColor = Color.Green;
                }

                else if (bmi <= 29.9)
                {
                    result = "Overweight";
                    txtBMI.BackColor = Color.Orange;
                    txtResult.BackColor = Color.Orange;
                }

                else if (bmi > 30)
                {
                    result = "Obese";
                    txtBMI.BackColor = Color.Red;
                    txtResult.BackColor = Color.Red;
                }
                else
                {
                    MessageBox.Show("ERROR");
                }

                txtBMI.Text = bmi.ToString("#.##");
                txtResult.Text = result;

            }

        }
    }
}
