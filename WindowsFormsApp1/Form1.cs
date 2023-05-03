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
using Emgu.CV.Structure;
using Emgu.CV.Face;
using Emgu.CV.CvEnum;
using System.Text.RegularExpressions;
using System.IO;
using System.Threading;
using System.Diagnostics;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        #region Variables
        public Capture videoCapture = null;
        public Image<Bgr, Byte> currentFrame = null;
        Mat frame = new Mat();
        
        #endregion
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            videoCapture = new Capture();
            videoCapture.ImageGrabbed += ProcessFrame;
            videoCapture.Start();
        }

        private void ProcessFrame(object sender, EventArgs e)
        {
            videoCapture.Retrieve(frame, 0);
            currentFrame = frame.ToImage<Bgr, Byte>().Resize(pictureCapture.Width, pictureCapture.Height, Inter.Cubic);
        }

    }
}
