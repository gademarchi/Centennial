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
 * Version: 0.1 - Create Form.
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

        private void CalculateBMIButton_Click(object sender, EventArgs e)
        {
            if (rdImperial.Checked ==  true)
            {
                txtHeight.Text = "Inches";
                txtWeight.Text = "Pounds";

                try
                {
                    lb = Convert.ToDouble(txtWeight.Text);
                    inch = Convert.ToDouble(txtHeight.Text);
                }
                catch { MessageBox.Show("Invalid value!"); }

                bmi = lb * 703 / Math.Pow(inch, 2);


            }

        }
    }
}
