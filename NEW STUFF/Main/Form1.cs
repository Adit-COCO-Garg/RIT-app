using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Main
{
    public partial class RITapp : Form
    {
        public RITapp()
        {
            InitializeComponent();
            this.SideBarPanel.BackgroundImage = Image.FromFile(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\Assets\\SideBarBG.jpg");
            this.eventsButton.Image = Image.FromFile(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\Assets\\events.png");
            this.diningButton.Image = Image.FromFile(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\Assets\\dining.png");
            this.coursesButton.Image = Image.FromFile(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\Assets\\courses.png");
            this.locationsButton.Image = Image.FromFile(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\Assets\\locations.png");
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

    }
}
