using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Courses
{
    public partial class CoursesForm : Form
    {
        public CoursesForm()
        {
            InitializeComponent();
            this.tableLayoutPanel2.BackgroundImage = Image.FromFile(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\Assets\\SideBar.jpg");
            this.eventsB.BackgroundImage = Image.FromFile(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\Assets\\calendar.png");
            this.diningB.BackgroundImage = Image.FromFile(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\Assets\\cutlery.png");
            this.locationsB.BackgroundImage = Image.FromFile(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\Assets\\map.png");
            this.coursesB.BackgroundImage = Image.FromFile(System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\Assets\\book.png");

            
        }
        
        private void CoursesB_Click(object sender, EventArgs e)
        {

        }

        private void LocationsB_Click(object sender, EventArgs e)
        {

        }

        private void TableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CellLayout_Click(object sender, EventArgs e)
        {
            
        }

        private void CellLayout_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.webView1.Navigate(new Uri(@"https://mycourses.rit.edu/d2l/home/765099"));
        }

        private void TableLayoutPanel3_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.webView1.Navigate(new Uri(@"https://mycourses.rit.edu/d2l/home/765097"));
        }

        private void TableLayoutPanel4_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.webView1.Navigate(new Uri(@"https://mycourses.rit.edu/d2l/home/765049"));
        }

        private void TableLayoutPanel5_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.webView1.Navigate(new Uri(@"https://mycourses.rit.edu/d2l/home/733058"));
        }

        private void EventsB_MouseHover(object sender, EventArgs e)
        {
            this.eventsB.BackColor = Color.FromArgb(0,0,0);
        }

        private void CoursesB_MouseHover(object sender, EventArgs e)
        {
            this.coursesB.BackColor = Color.FromArgb(0, 0, 0);
        }

        private void LocationsB_Click_1(object sender, EventArgs e)
        {
            
        }

        private void LocationsB_MouseHover(object sender, EventArgs e)
        {
            this.locationsB.BackColor = Color.FromArgb(0, 0, 0);
        }

        private void DiningB_MouseHover(object sender, EventArgs e)
        {
            this.diningB.BackColor = Color.FromArgb(0, 0, 0);
        }
    }
}
