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
 * Version: 0.5 - add a label for show the result.
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

        private void rdImperial_CheckedChanged(object sender, EventArgs e)
        {
            txtHeight.Tag = "Inches";
            txtWeight.Tag = "Pounds";

        }


        private void rdMetric_CheckedChanged(object sender, EventArgs e)
        {
            txtHeight.Tag = "Meters";
            txtWeight.Tag = "Kg";
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtHeight.Clear();
            txtWeight.Clear();
            txtBMI.Clear();

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
                }

                else if(bmi <= 24.9)
                {
                    result = "Normal weight";
                }

                else if(bmi <= 29.9)
                {
                    result = "Overweight";
                }

                else if (bmi > 30)
                {
                    result = "Obese";
                }
                else
                {
                    MessageBox.Show("ERROR");
                }

                txtBMI.Text = bmi.ToString("#.##");
                lblResult.Text = result;

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
                }

                else if (bmi <= 24.9)
                {
                    result = "Normal weight";
                }

                else if (bmi <= 29.9)
                {
                    result = "Overweight";
                }

                else if (bmi > 30)
                {
                    result = "Obese";
                }
                else
                {
                    MessageBox.Show("ERROR");
                }

                txtBMI.Text = bmi.ToString("#.##");
                lblResult.Text = result;

            }

        }
    }
}
