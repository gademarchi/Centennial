using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/* Name: Gabriel De MArchi
 * Date: August 17, 2017
 * Description: This is the SplashForm that appears for three seconds
 * and launches the  application.
 * Version: 0.2 - Refactored the "Tick" event handler
 */

namespace COMP123_S2017_FinalExam_300930749
{
    public partial class SplashForm : Form
    {
        //PROPERTIES
        public PickHighestCardForm PickHighestCardForm
        {
            get
            {
               return Program.pickhighestcardForm;
            }

        }
        public SplashForm()
        {
            InitializeComponent();
        }


        private void SplashFormTimer_Tick(object sender, EventArgs e)
        {
            this.PickHighestCardForm.Show();
            this.Hide();
            SplashFormTimer.Enabled = false;
        }
    }
}
