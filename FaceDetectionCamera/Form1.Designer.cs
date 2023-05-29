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
            dgvLogs = new DataGridView();
            btnLoadData = new Button();
            lblRoomNumber = new Label();
            nudRoomNumber = new NumericUpDown();
            btnDeleteAll = new Button();
            btnDeleteById = new Button();
            nudIdToDelete = new NumericUpDown();
            btnUpdateById = new Button();
            nudIdToUpdate = new NumericUpDown();
            lblCCTVId = new Label();
            tbCCTVId = new TextBox();
            label2 = new Label();
            nudRoomNumberToUpdate = new NumericUpDown();
            lblCurrentPeople = new Label();
            nudCurrentPeopleToUpdate = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)picBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvLogs).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudRoomNumber).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudIdToDelete).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudIdToUpdate).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudRoomNumberToUpdate).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudCurrentPeopleToUpdate).BeginInit();
            SuspendLayout();
            // 
            // btnStart
            // 
            btnStart.Location = new Point(435, 10);
            btnStart.Margin = new Padding(2);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(191, 23);
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
            lblDateTime.Location = new Point(435, 107);
            lblDateTime.Margin = new Padding(2, 0, 2, 0);
            lblDateTime.Name = "lblDateTime";
            lblDateTime.Size = new Size(33, 15);
            lblDateTime.TabIndex = 4;
            lblDateTime.Text = "Time";
            // 
            // lblFacesDetected
            // 
            lblFacesDetected.AutoSize = true;
            lblFacesDetected.Location = new Point(526, 128);
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
            lbLogs.Location = new Point(646, 7);
            lbLogs.Margin = new Padding(2);
            lbLogs.Name = "lbLogs";
            lbLogs.Size = new Size(250, 274);
            lbLogs.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(435, 128);
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
            btnStop.Size = new Size(191, 25);
            btnStop.TabIndex = 9;
            btnStop.Text = "Stop";
            btnStop.UseVisualStyleBackColor = true;
            btnStop.Click += btnStop_Click;
            // 
            // dgvLogs
            // 
            dgvLogs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLogs.Location = new Point(25, 312);
            dgvLogs.Margin = new Padding(2);
            dgvLogs.Name = "dgvLogs";
            dgvLogs.RowHeadersWidth = 62;
            dgvLogs.RowTemplate.Height = 33;
            dgvLogs.Size = new Size(870, 252);
            dgvLogs.TabIndex = 12;
            // 
            // btnLoadData
            // 
            btnLoadData.Location = new Point(914, 312);
            btnLoadData.Margin = new Padding(2);
            btnLoadData.Name = "btnLoadData";
            btnLoadData.Size = new Size(191, 20);
            btnLoadData.TabIndex = 13;
            btnLoadData.Text = "Load data";
            btnLoadData.UseVisualStyleBackColor = true;
            btnLoadData.Click += btnLoadData_Click;
            // 
            // lblRoomNumber
            // 
            lblRoomNumber.AutoSize = true;
            lblRoomNumber.Location = new Point(435, 82);
            lblRoomNumber.Margin = new Padding(2, 0, 2, 0);
            lblRoomNumber.Name = "lblRoomNumber";
            lblRoomNumber.Size = new Size(61, 15);
            lblRoomNumber.TabIndex = 14;
            lblRoomNumber.Text = "Room No:";
            // 
            // nudRoomNumber
            // 
            nudRoomNumber.Location = new Point(512, 82);
            nudRoomNumber.Margin = new Padding(2);
            nudRoomNumber.Name = "nudRoomNumber";
            nudRoomNumber.Size = new Size(114, 23);
            nudRoomNumber.TabIndex = 15;
            // 
            // btnDeleteAll
            // 
            btnDeleteAll.Location = new Point(914, 343);
            btnDeleteAll.Margin = new Padding(2);
            btnDeleteAll.Name = "btnDeleteAll";
            btnDeleteAll.Size = new Size(191, 20);
            btnDeleteAll.TabIndex = 16;
            btnDeleteAll.Text = "Delete all data";
            btnDeleteAll.UseVisualStyleBackColor = true;
            btnDeleteAll.Click += btnDeleteAll_Click;
            // 
            // btnDeleteById
            // 
            btnDeleteById.Location = new Point(914, 375);
            btnDeleteById.Margin = new Padding(2);
            btnDeleteById.Name = "btnDeleteById";
            btnDeleteById.Size = new Size(120, 20);
            btnDeleteById.TabIndex = 17;
            btnDeleteById.Text = "Delete by Id";
            btnDeleteById.UseVisualStyleBackColor = true;
            btnDeleteById.Click += btnDeleteById_Click;
            // 
            // nudIdToDelete
            // 
            nudIdToDelete.Location = new Point(1044, 376);
            nudIdToDelete.Margin = new Padding(2);
            nudIdToDelete.Name = "nudIdToDelete";
            nudIdToDelete.Size = new Size(60, 23);
            nudIdToDelete.TabIndex = 18;
            // 
            // btnUpdateById
            // 
            btnUpdateById.Location = new Point(914, 434);
            btnUpdateById.Margin = new Padding(2);
            btnUpdateById.Name = "btnUpdateById";
            btnUpdateById.Size = new Size(120, 20);
            btnUpdateById.TabIndex = 19;
            btnUpdateById.Text = "Update by Id";
            btnUpdateById.UseVisualStyleBackColor = true;
            btnUpdateById.Click += btnUpdateById_Click;
            // 
            // nudIdToUpdate
            // 
            nudIdToUpdate.Location = new Point(1044, 435);
            nudIdToUpdate.Margin = new Padding(2);
            nudIdToUpdate.Name = "nudIdToUpdate";
            nudIdToUpdate.Size = new Size(60, 23);
            nudIdToUpdate.TabIndex = 20;
            // 
            // lblCCTVId
            // 
            lblCCTVId.AutoSize = true;
            lblCCTVId.Location = new Point(914, 468);
            lblCCTVId.Margin = new Padding(2, 0, 2, 0);
            lblCCTVId.Name = "lblCCTVId";
            lblCCTVId.Size = new Size(49, 15);
            lblCCTVId.TabIndex = 21;
            lblCCTVId.Text = "CCTVId:";
            // 
            // tbCCTVId
            // 
            tbCCTVId.Location = new Point(970, 466);
            tbCCTVId.Margin = new Padding(2);
            tbCCTVId.Name = "tbCCTVId";
            tbCCTVId.Size = new Size(136, 23);
            tbCCTVId.TabIndex = 22;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(914, 496);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(61, 15);
            label2.TabIndex = 23;
            label2.Text = "Room No:";
            // 
            // nudRoomNumberToUpdate
            // 
            nudRoomNumberToUpdate.Location = new Point(1044, 495);
            nudRoomNumberToUpdate.Margin = new Padding(2);
            nudRoomNumberToUpdate.Name = "nudRoomNumberToUpdate";
            nudRoomNumberToUpdate.Size = new Size(60, 23);
            nudRoomNumberToUpdate.TabIndex = 24;
            // 
            // lblCurrentPeople
            // 
            lblCurrentPeople.AutoSize = true;
            lblCurrentPeople.Location = new Point(914, 526);
            lblCurrentPeople.Margin = new Padding(2, 0, 2, 0);
            lblCurrentPeople.Name = "lblCurrentPeople";
            lblCurrentPeople.Size = new Size(89, 15);
            lblCurrentPeople.TabIndex = 25;
            lblCurrentPeople.Text = "Current people:";
            // 
            // nudCurrentPeopleToUpdate
            // 
            nudCurrentPeopleToUpdate.Location = new Point(1044, 524);
            nudCurrentPeopleToUpdate.Margin = new Padding(2);
            nudCurrentPeopleToUpdate.Name = "nudCurrentPeopleToUpdate";
            nudCurrentPeopleToUpdate.Size = new Size(60, 23);
            nudCurrentPeopleToUpdate.TabIndex = 26;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(1121, 586);
            Controls.Add(nudCurrentPeopleToUpdate);
            Controls.Add(lblCurrentPeople);
            Controls.Add(nudRoomNumberToUpdate);
            Controls.Add(label2);
            Controls.Add(tbCCTVId);
            Controls.Add(lblCCTVId);
            Controls.Add(nudIdToUpdate);
            Controls.Add(btnUpdateById);
            Controls.Add(nudIdToDelete);
            Controls.Add(btnDeleteById);
            Controls.Add(btnDeleteAll);
            Controls.Add(nudRoomNumber);
            Controls.Add(lblRoomNumber);
            Controls.Add(btnLoadData);
            Controls.Add(dgvLogs);
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
            ((System.ComponentModel.ISupportInitialize)dgvLogs).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudRoomNumber).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudIdToDelete).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudIdToUpdate).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudRoomNumberToUpdate).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudCurrentPeopleToUpdate).EndInit();
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
        private DataGridView dgvLogs;
        private Button btnLoadData;
        private Label lblRoomNumber;
        private NumericUpDown nudRoomNumber;
        private Button btnDeleteAll;
        private Button btnDeleteById;
        private NumericUpDown nudIdToDelete;
        private Button btnUpdateById;
        private NumericUpDown nudIdToUpdate;
        private Label lblCCTVId;
        private TextBox tbCCTVId;
        private Label label2;
        private NumericUpDown nudRoomNumberToUpdate;
        private Label lblCurrentPeople;
        private NumericUpDown nudCurrentPeopleToUpdate;
    }
}