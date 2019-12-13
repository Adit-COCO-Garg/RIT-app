using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiningPage
{
    public partial class diningForm : Form //this code has been fully integrated into the main form - this external form is currently obsolete.
    {
        
        public diningForm(double dining, double tiger, int swipes, int exchanges)
        {
            InitializeComponent();
            diningLabel.Text = dining.ToString("C");
            tigerLabel.Text = tiger.ToString("C");
            swipeLabel.Text = $"{swipes.ToString()} Swipes Remaining";
            exchangeLabel.Text = $"{exchanges.ToString()} Exchanges Remaining";
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DiningLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
