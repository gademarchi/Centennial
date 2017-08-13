using System;
using System.Collections.Generic;
using System.Linq;
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
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new BMICalculator());
        }
    }
}
