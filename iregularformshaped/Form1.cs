using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
namespace iregularformshaped
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        [DllImport("User32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("User32.dll")]
        public static extern int SendMessage(IntPtr Handle, int
        Msg, int Param1, int Param2);
        public bool ismd = false;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
             this.Close();
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                //ReleaseCapture();
                //SendMessage(Handle, 0xA1, 0x2, 0);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           // this.Close();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            ismd = true;
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            ismd = false;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (ismd == true)
            {
                //this.Left = e.X;
                //this.Top = e.Y;
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            ismd = false;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (ismd == true)
            {
                this.Left = pictureBox1.Left + e.X;
                this.Top = pictureBox1.Top + e.Y;
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            ismd = true;
        }
    }
}
