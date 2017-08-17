using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Name: Gabriel De Marchi  
 * Date: August 17,2017
 * StudentID: 300930749
 * Description: Program
 * Version: 0.1 - Create Program
 */

namespace COMP123_S2017_FinalExam_300930749
{
    public static class Program
    {
        public static PickHighestCardForm pickhighestcardForm { get; internal set; }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            pickhighestcardForm = new PickHighestCardForm();

            Application.Run(new PickHighestCardForm());
        }
    }
}
