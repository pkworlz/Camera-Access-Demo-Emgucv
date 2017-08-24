using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Emgu.CV;

namespace Camera_Access_Demo
{
    public partial class Form1 : Form
    {
        VideoCapture capture;
        public Form1()
        {
            InitializeComponent();
            Run();
        }

        private void Run()
        {
            try
            {
                capture = new VideoCapture();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
                return;
            }
            Application.Idle += ProcessFrame;
        }

        private void ProcessFrame(object sender, EventArgs e)
        {
            imageBox1.Image = capture.QuerySmallFrame();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
