using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedStory_Admin
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            activeMark.Height = ForumButton.Height;
            activeMark.Top = ForumButton.Top;
            forum_Database1.BringToFront();
        } 

        private void windowSize(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void turnOff(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minimize(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }


        private void moveWindow(object sender, MouseEventArgs e)
        {

        }
        private bool mouseDown;
        private Point lastLocation;
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void ForumButton_Click(object sender, EventArgs e)
        {
            activeMark.Height = ForumButton.Height;
            activeMark.Top = ForumButton.Top;
            forum_Database1.BringToFront();
        }

        private void PenggunaButton_Click(object sender, EventArgs e)
        {
            activeMark.Height = PenggunaButton.Height;
            activeMark.Top = PenggunaButton.Top;
            pengguna_Database1.BringToFront();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            this.pengguna_Database1.displayUser();
            this.forum_Database1.displayDiskusi();
            this.forum_Database1.displayDiskusiTerbalas();
            this.asupan_Database1.displayAsupan();
        }

        private void AsupanButton_Click(object sender, EventArgs e)
        {
            activeMark.Height = AsupanButton.Height;
            activeMark.Top = AsupanButton.Top;
            asupan_Database1.BringToFront();
        }

        private void NomorDaruratButton_Click(object sender, EventArgs e)
        {
            
            
        }
    }
}
