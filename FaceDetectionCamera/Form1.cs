using AForge.Video;
using AForge.Video.DirectShow;
using Emgu.CV;
using Emgu.CV.Structure;
using System.Data.SqlClient;
using System.Data;



namespace FaceDetectionCamera
{
    public partial class Form1 : Form
    {
        FilterInfoCollection filter;
        VideoCaptureDevice device;
        //Load the available camera devices
        int facesDetected = 0;
        static readonly CascadeClassifier cascadeClassifier = new CascadeClassifier("haarcascade_frontalface_alt_tree.xml");
        //Setup the face recognizing algorithm
        DataAccessLayer dal = new DataAccessLayer();

        public Form1()
        {
            InitializeComponent();
            filter = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            device = new VideoCaptureDevice();
            DataAccessLayer dal = new DataAccessLayer();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            appTimer.Start();
            foreach (FilterInfo device in filter)
                cboDevice.Items.Add(device.Name);
            cboDevice.SelectedIndex = 0;
            lblFacesDetected.Text = "0";
            btnStop.Enabled = false;

            nudRoomNumber.Value = 1;
            nudRoomNumber.Minimum = 1;
            nudRoomNumber.Maximum = 999;

            nudIdToDelete.Minimum = 1;
            nudIdToDelete.Maximum = 999;

            nudIdToUpdate.Minimum = 0;
            nudIdToUpdate.Maximum = 999;

            nudRoomNumberToUpdate.Minimum = 1;
            nudRoomNumberToUpdate.Maximum = 999;

            nudCurrentPeopleToUpdate.Minimum = 1;
            nudCurrentPeopleToUpdate.Maximum = 999;
            //Put a maximum quantity of the values so it isn't set as 100 by default
        }

        private void appTimer_Tick(object sender, EventArgs e)
        {
            lblDateTime.Text = DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss");
            lblFacesDetected.Text = facesDetected.ToString();
            if (facesDetected != 0)
            {
                lbLogs.Items.Add(lblDateTime.Text + " : " + lblFacesDetected.Text);
                InsertData(DateTime.Now, Convert.ToInt32(nudRoomNumber.Value), facesDetected);
            }
            if (facesDetected == 0)
                lblFacesDetected.Text = "0";
            //Timer and a check if a face is detected
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            device = new VideoCaptureDevice(filter[cboDevice.SelectedIndex].MonikerString);
            device.NewFrame += Device_NewFrame;
            device.Start();
            btnStart.Enabled = false;
            btnStop.Enabled = true;
            nudRoomNumber.Enabled = false;
            //Blank the Start button when a new device is paired
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
            picBox.Image = bitmap;
            //Use rectangles as a way of highlighting the face
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
            nudRoomNumber.Enabled = true;
            picBox.Image = null;
        }





        private void btnLoadData_Click(object sender, EventArgs e)
        {
            DisplayData();
        }

        private void DisplayData()
        {
            dgvLogs.DataSource = dal.DisplayData();
            dgvLogs.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvLogs.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void InsertData(DateTime timeOfDetection, int roomNumber, int faces)
        {
            string deviceName = cboDevice.SelectedItem.ToString() + "";
            dal.InsertData(deviceName, timeOfDetection, roomNumber, faces);
            DisplayData();
        }

        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            dal.DeleteAll();
            DisplayData();
        }


        private void btnDeleteById_Click(object sender, EventArgs e)
        {
            dal.DeleteById(Convert.ToInt32(nudIdToDelete.Value));
            DisplayData();
        }


        private void btnUpdateById_Click(object sender, EventArgs e)
        {
            dal.UpdateById(Convert.ToInt32(nudIdToUpdate.Value), tbCCTVId.Text, Convert.ToInt32(nudRoomNumberToUpdate.Value), Convert.ToInt32(nudCurrentPeopleToUpdate.Value));
            nudIdToUpdate.Value = 0;
            nudRoomNumberToUpdate.Value = 1;
            nudCurrentPeopleToUpdate.Value = 1;
            tbCCTVId.Text = "";
            DisplayData();
        }

    }
}