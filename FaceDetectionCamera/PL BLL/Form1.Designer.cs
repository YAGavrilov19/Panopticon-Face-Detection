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
            this.components = new System.ComponentModel.Container();
            this.btnStart = new System.Windows.Forms.Button();
            this.cboDevice = new System.Windows.Forms.ComboBox();
            this.lblDevice = new System.Windows.Forms.Label();
            this.picBox = new System.Windows.Forms.PictureBox();
            this.appTimer = new System.Windows.Forms.Timer(this.components);
            this.lblDateTime = new System.Windows.Forms.Label();
            this.lblFacesDetected = new System.Windows.Forms.Label();
            this.lbLogs = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSaveLogs = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblMaxFacesDetected = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(435, 10);
            this.btnStart.Margin = new System.Windows.Forms.Padding(2);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(136, 23);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            // 
            // cboDevice
            // 
            this.cboDevice.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDevice.FormattingEnabled = true;
            this.cboDevice.Location = new System.Drawing.Point(77, 10);
            this.cboDevice.Margin = new System.Windows.Forms.Padding(2);
            this.cboDevice.Name = "cboDevice";
            this.cboDevice.Size = new System.Drawing.Size(342, 23);
            this.cboDevice.TabIndex = 1;
            // 
            // lblDevice
            // 
            this.lblDevice.AutoSize = true;
            this.lblDevice.Location = new System.Drawing.Point(25, 12);
            this.lblDevice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDevice.Name = "lblDevice";
            this.lblDevice.Size = new System.Drawing.Size(45, 15);
            this.lblDevice.TabIndex = 2;
            this.lblDevice.Text = "Device:";
            // 
            // picBox
            // 
            this.picBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picBox.Location = new System.Drawing.Point(25, 43);
            this.picBox.Margin = new System.Windows.Forms.Padding(2);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(393, 235);
            this.picBox.TabIndex = 3;
            this.picBox.TabStop = false;
            // 
            // lblDateTime
            // 
            this.lblDateTime.AutoSize = true;
            this.lblDateTime.Location = new System.Drawing.Point(435, 79);
            this.lblDateTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(33, 15);
            this.lblDateTime.TabIndex = 4;
            this.lblDateTime.Text = "Time";
            // 
            // lblFacesDetected
            // 
            this.lblFacesDetected.AutoSize = true;
            this.lblFacesDetected.Location = new System.Drawing.Point(435, 125);
            this.lblFacesDetected.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFacesDetected.Name = "lblFacesDetected";
            this.lblFacesDetected.Size = new System.Drawing.Size(96, 15);
            this.lblFacesDetected.TabIndex = 5;
            this.lblFacesDetected.Text = "lblFacesDetected";
            // 
            // lbLogs
            // 
            this.lbLogs.FormattingEnabled = true;
            this.lbLogs.ItemHeight = 15;
            this.lbLogs.Location = new System.Drawing.Point(25, 290);
            this.lbLogs.Margin = new System.Windows.Forms.Padding(2);
            this.lbLogs.Name = "lbLogs";
            this.lbLogs.Size = new System.Drawing.Size(394, 94);
            this.lbLogs.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(435, 104);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "Faces detected:";
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(435, 43);
            this.btnStop.Margin = new System.Windows.Forms.Padding(2);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(136, 22);
            this.btnStop.TabIndex = 9;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(435, 290);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(136, 25);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "Clear logs";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnSaveLogs
            // 
            this.btnSaveLogs.Location = new System.Drawing.Point(435, 319);
            this.btnSaveLogs.Margin = new System.Windows.Forms.Padding(2);
            this.btnSaveLogs.Name = "btnSaveLogs";
            this.btnSaveLogs.Size = new System.Drawing.Size(136, 24);
            this.btnSaveLogs.TabIndex = 11;
            this.btnSaveLogs.Text = "Save logs";
            this.btnSaveLogs.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(435, 149);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 15);
            this.label2.TabIndex = 12;
            this.label2.Text = "Maximum Faces detected:";
            // 
            // lblMaxFacesDetected
            // 
            this.lblMaxFacesDetected.AutoSize = true;
            this.lblMaxFacesDetected.Location = new System.Drawing.Point(435, 174);
            this.lblMaxFacesDetected.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMaxFacesDetected.Name = "lblMaxFacesDetected";
            this.lblMaxFacesDetected.Size = new System.Drawing.Size(119, 15);
            this.lblMaxFacesDetected.TabIndex = 13;
            this.lblMaxFacesDetected.Text = "lblMaxFacesDetected";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(589, 393);
            this.Controls.Add(this.lblMaxFacesDetected);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSaveLogs);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbLogs);
            this.Controls.Add(this.lblFacesDetected);
            this.Controls.Add(this.lblDateTime);
            this.Controls.Add(this.picBox);
            this.Controls.Add(this.lblDevice);
            this.Controls.Add(this.cboDevice);
            this.Controls.Add(this.btnStart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Face Detection Camera";
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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