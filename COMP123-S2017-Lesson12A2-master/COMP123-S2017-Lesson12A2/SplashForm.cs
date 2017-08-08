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
 * Name: Gabriel De Marchi
 * Date: August 8,2017
 * Decribe: Create a splash form
 * version: 0.1
 */


namespace COMP123_S2017_Lesson12A2
{
    public partial class SplashForm : Form
    {
        public SplashForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// this is the event handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SplashFormTimer_Tick(object sender, EventArgs e)
        {
            CalculatorForm calculatorForm = new CalculatorForm();
            calculatorForm.Show();
            this.Hide();
            SplashFormTimer.Enabled = false;

        }
    }
}
