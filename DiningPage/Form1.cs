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
    public partial class diningForm : Form
    {
        public class Student
        {
            public double dining;
            public double tiger;
            public int swipes;
            public Student(double dD, double tB, int nS = -1)
            {
                dining = dD;
                tiger = tB;
                swipes = nS;
            }
        }
        public diningForm()
        {
            InitializeComponent();
            Student student = new Student(3300.45, 250.00, 5); //this will probably be re-implemented with a call to the database.
            diningLabel.Text = student.dining.ToString("C");
            tigerLabel.Text = student.tiger.ToString("C");
            if (student.swipes >= 0)
            {
                swipeLabel.Text = $"{student.swipes.ToString()} Swipes Remaining";
                swipeLabel.Visible = true;
            }
            else
            {
                swipeLabel.Visible = false;
            }
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
