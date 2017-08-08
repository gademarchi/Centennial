using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

/* Name: Tom Tsiliopoulos
 * Date: August 3, 2017
 * Description: A calculator app with splash forms
 * Version: 0.2 - Create a splash form
 */

namespace COMP123_S2017_Lesson12A2
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
            Application.Run(new Calculator());
        }
    }
}
