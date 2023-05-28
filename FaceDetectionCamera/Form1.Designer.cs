namespace FaceDetectionCamera
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            btnStart = new Button();
            cboDevice = new ComboBox();
            lblDevice = new Label();
            picBox = new PictureBox();
            appTimer = new System.Windows.Forms.Timer(components);
            lblDateTime = new Label();
            lblFacesDetected = new Label();
            lbLogs = new ListBox();
            label1 = new Label();
            btnStop = new Button();
            btnClear = new Button();
            btnSaveLogs = new Button();
            label2 = new Label();
            lblMaxFacesDetected = new Label();
            ((System.ComponentModel.ISupportInitialize)picBox).BeginInit();
            SuspendLayout();
            // 
            // btnStart
            // 
            btnStart.Location = new Point(435, 10);
            btnStart.Margin = new Padding(2);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(136, 20);
            btnStart.TabIndex = 0;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // cboDevice
            // 
            cboDevice.DropDownStyle = ComboBoxStyle.DropDownList;
            cboDevice.FormattingEnabled = true;
            cboDevice.Location = new Point(77, 10);
            cboDevice.Margin = new Padding(2);
            cboDevice.Name = "cboDevice";
            cboDevice.Size = new Size(342, 23);
            cboDevice.TabIndex = 1;
            // 
            // lblDevice
            // 
            lblDevice.AutoSize = true;
            lblDevice.Location = new Point(25, 12);
            lblDevice.Margin = new Padding(2, 0, 2, 0);
            lblDevice.Name = "lblDevice";
            lblDevice.Size = new Size(45, 15);
            lblDevice.TabIndex = 2;
            lblDevice.Text = "Device:";
            // 
            // picBox
            // 
            picBox.BorderStyle = BorderStyle.FixedSingle;
            picBox.Location = new Point(25, 43);
            picBox.Margin = new Padding(2);
            picBox.Name = "picBox";
            picBox.Size = new Size(393, 235);
            picBox.TabIndex = 3;
            picBox.TabStop = false;
            // 
            // appTimer
            // 
            appTimer.Tick += appTimer_Tick;
            // 
            // lblDateTime
            // 
            lblDateTime.AutoSize = true;
            lblDateTime.Location = new Point(435, 79);
            lblDateTime.Margin = new Padding(2, 0, 2, 0);
            lblDateTime.Name = "lblDateTime";
            lblDateTime.Size = new Size(33, 15);
            lblDateTime.TabIndex = 4;
            lblDateTime.Text = "Time";
            // 
            // lblFacesDetected
            // 
            lblFacesDetected.AutoSize = true;
            lblFacesDetected.Location = new Point(435, 125);
            lblFacesDetected.Margin = new Padding(2, 0, 2, 0);
            lblFacesDetected.Name = "lblFacesDetected";
            lblFacesDetected.Size = new Size(96, 15);
            lblFacesDetected.TabIndex = 5;
            lblFacesDetected.Text = "lblFacesDetected";
            // 
            // lbLogs
            // 
            lbLogs.FormattingEnabled = true;
            lbLogs.ItemHeight = 15;
            lbLogs.Location = new Point(25, 290);
            lbLogs.Margin = new Padding(2);
            lbLogs.Name = "lbLogs";
            lbLogs.Size = new Size(394, 94);
            lbLogs.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(435, 104);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(88, 15);
            label1.TabIndex = 8;
            label1.Text = "Faces detected:";
            // 
            // btnStop
            // 
            btnStop.Location = new Point(435, 43);
            btnStop.Margin = new Padding(2);
            btnStop.Name = "btnStop";
            btnStop.Size = new Size(136, 20);
            btnStop.TabIndex = 9;
            btnStop.Text = "Stop";
            btnStop.UseVisualStyleBackColor = true;
            btnStop.Click += btnStop_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(435, 290);
            btnClear.Margin = new Padding(2);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(136, 20);
            btnClear.TabIndex = 10;
            btnClear.Text = "Clear logs";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnSaveLogs
            // 
            btnSaveLogs.Location = new Point(435, 319);
            btnSaveLogs.Margin = new Padding(2);
            btnSaveLogs.Name = "btnSaveLogs";
            btnSaveLogs.Size = new Size(136, 20);
            btnSaveLogs.TabIndex = 11;
            btnSaveLogs.Text = "Save logs";
            btnSaveLogs.UseVisualStyleBackColor = true;
            btnSaveLogs.Click += btnSaveLogs_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(435, 149);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(146, 15);
            label2.TabIndex = 12;
            label2.Text = "Maximum Faces detected:";
            // 
            // lblMaxFacesDetected
            // 
            lblMaxFacesDetected.AutoSize = true;
            lblMaxFacesDetected.Location = new Point(435, 174);
            lblMaxFacesDetected.Margin = new Padding(2, 0, 2, 0);
            lblMaxFacesDetected.Name = "lblMaxFacesDetected";
            lblMaxFacesDetected.Size = new Size(119, 15);
            lblMaxFacesDetected.TabIndex = 13;
            lblMaxFacesDetected.Text = "lblMaxFacesDetected";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(589, 393);
            Controls.Add(lblMaxFacesDetected);
            Controls.Add(label2);
            Controls.Add(btnSaveLogs);
            Controls.Add(btnClear);
            Controls.Add(btnStop);
            Controls.Add(label1);
            Controls.Add(lbLogs);
            Controls.Add(lblFacesDetected);
            Controls.Add(lblDateTime);
            Controls.Add(picBox);
            Controls.Add(lblDevice);
            Controls.Add(cboDevice);
            Controls.Add(btnStart);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(2);
            Name = "Form1";
            Text = "Face Detection Camera";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)picBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnStart;
        private ComboBox cboDevice;
        private Label lblDevice;
        private PictureBox picBox;
        private System.Windows.Forms.Timer appTimer;
        private Label lblDateTime;
        private Label lblFacesDetected;
        private ListBox lbLogs;
        private Label label1;
        private Button btnStop;
        private Button btnClear;
        private Button btnSaveLogs;
        private Label label2;
        private Label lblMaxFacesDetected;
    }
}