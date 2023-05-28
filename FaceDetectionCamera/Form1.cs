using AForge.Video;
using AForge.Video.DirectShow;
using Emgu.CV;
using Emgu.CV.Structure;


namespace FaceDetectionCamera
{
    public partial class Form1 : Form
    {
        FilterInfoCollection filter;
        VideoCaptureDevice device;
        int facesDetected = 0;
        int maxFacesDetected = 0;  // Maximum faces detected in the last hour
        DateTime startTime;
        int selectedDeviceIndex;

        static readonly CascadeClassifier cascadeClassifier = new CascadeClassifier("haarcascade_frontalface_alt_tree.xml");
        //Detects camera devices and selects the face detecting algorithm

        public Form1()
        {
            InitializeComponent();
            filter = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            device = new VideoCaptureDevice();
            //Sets up the camera as the device used in the program
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            appTimer.Start();

            for (selectedDeviceIndex = 0; selectedDeviceIndex < filter.Count; selectedDeviceIndex++)
            {
                cboDevice.Items.Add($"{selectedDeviceIndex + 1}: {filter[selectedDeviceIndex].Name}");
            }

            cboDevice.SelectedIndex = 0;
            lblFacesDetected.Text = "0";
            lblMaxFacesDetected.Text = "0";
            btnStop.Enabled = false;
            //Blanks the button "Stop" since the program has just started and sets the starting face detecting value as 0
        }

        private void appTimer_Tick(object sender, EventArgs e)
        {
            lblDateTime.Text = DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss");
            lblFacesDetected.Text = facesDetected.ToString();
            lblMaxFacesDetected.Text = maxFacesDetected.ToString();
            if (facesDetected != 0)
                lbLogs.Items.Add(lblDateTime.Text + " - " + lblFacesDetected.Text);
            if (facesDetected == 0)
                lblFacesDetected.Text = "0";
            //Creates a timer which adds the face information along with the time at which it occured to the log
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            startTime = DateTime.Now;
            device = new VideoCaptureDevice(filter[cboDevice.SelectedIndex].MonikerString);
            device.NewFrame += Device_NewFrame;
            device.Start();
            btnStart.Enabled = false;
            btnStop.Enabled = true;
        }

        private void Device_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            facesDetected = 0;
            Bitmap bitmap = (Bitmap)eventArgs.Frame.Clone();
            Image<Bgr, byte> grayImage = bitmap.ToImage<Bgr, byte>();
            Rectangle[] rectangles = cascadeClassifier.DetectMultiScale(grayImage, 1.4, 1);
            foreach (Rectangle rectangle in rectangles)
            {
                using (Graphics graphics = Graphics.FromImage(bitmap))
                {
                    using (Pen pen = new Pen(Color.Green, 10))
                    {
                        graphics.DrawRectangle(pen, rectangle);
                    }
                }
                facesDetected = rectangles.Distinct().Count();
            }
            if (facesDetected > maxFacesDetected)
            {
                maxFacesDetected = facesDetected;
            }
            TimeSpan elapsedTime = DateTime.Now - startTime;
            if (elapsedTime.TotalHours >= 1)
            {
                // Reset the maximum faces detected if the last hour has passed
                maxFacesDetected = 0;
                lblMaxFacesDetected.Text = "0";
                startTime = DateTime.Now;
            }
            picBox.Image = bitmap;
            //Crates the rectangles surrounding the faces along with counting them
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (device.IsRunning)
            {
                device.SignalToStop();
                device.WaitForStop();
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            if (device.IsRunning)
            {
                device.SignalToStop();
                device.WaitForStop();
            }
            btnStart.Enabled = true;
            btnStop.Enabled = false;
            picBox.Image = null;
            //Empties the box containing the camera
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lbLogs.Items.Clear();
        }

        private void btnSaveLogs_Click(object sender, EventArgs e)
        {
            if (lbLogs.Items.Count > 0)
            {
                //const string sPath = "logs.txt";
                string sPath = DateTime.Now.ToString("dd-MM-yyyy-HH-mm-ss") + "-logs.txt";
                StreamWriter SaveFile = new StreamWriter(sPath);
                foreach (var item in lbLogs.Items)
                {
                    SaveFile.WriteLine(item);
                }
                SaveFile.Close();
                MessageBox.Show("Logs saved!", "Face Detection Camera");
            }
            else
                MessageBox.Show("Nothing to save.", "Face Detection Camera");
        }
        //Saves the logs to a file along with checking if there's any
    }
}