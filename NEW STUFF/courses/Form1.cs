using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace courses
{
    public partial class CoursesTab : Form
    {
        public CoursesTab()
        {
            InitializeComponent();
            this.SideBarPanel.BackgroundImage = Image.FromFile(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\Assets\\SideBarBG.jpg");
            this.eventsButton.Image = Image.FromFile(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\Assets\\events.png");
            this.diningButton.Image = Image.FromFile(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\Assets\\dining.png");
            this.coursesButton.Image = Image.FromFile(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\Assets\\courses.png");
            this.locationsButton.Image = Image.FromFile(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\Assets\\locations.png");
        }


        private void CourseRow1L_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.webView1.Navigate("https://mycourses.rit.edu/d2l/home/765099");
        }

        private void CourseRow2L_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.webView1.Navigate("https://mycourses.rit.edu/d2l/home/763739");
        }

        private void CourseRow3L_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.webView1.Navigate("https://mycourses.rit.edu/d2l/home/765097");
        }

        private void CourseRow4L_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.webView1.Navigate("https://mycourses.rit.edu/d2l/home/733058");
        }
    }
}
