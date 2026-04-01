namespace OOP_Project_Jonathan_Alex_Abdin
{
    partial class frmFleetDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFleetDashboard));
            grpRegistration = new GroupBox();
            radTruck = new RadioButton();
            radVan = new RadioButton();
            radCar = new RadioButton();
            radDrone = new RadioButton();
            radBike = new RadioButton();
            lblgrpBack = new Label();
            btnRegister = new Button();
            btnAssignDriver = new Button();
            btnManageCargo = new Button();
            btnRemoveVehicle = new Button();
            btnExit = new Button();
            lstFleet = new ListBox();
            label1 = new Label();
            lblTotalCount = new Label();
            grpVehicleDetails = new GroupBox();
            lblFuelStatus = new Label();
            lblFuelPercent = new Label();
            lblDisplayMaxPayload = new Label();
            label2 = new Label();
            label9 = new Label();
            label15 = new Label();
            lblDisplayFuelType = new Label();
            lblDisplayPayload = new Label();
            lblDisplayDriver = new Label();
            lblDisplayType = new Label();
            lblDisplayID = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            picBike = new PictureBox();
            picDrone = new PictureBox();
            picCar = new PictureBox();
            picVan = new PictureBox();
            picTruck = new PictureBox();
            btnManageFuel = new Button();
            grpRegistration.SuspendLayout();
            grpVehicleDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picBike).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picDrone).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picCar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picVan).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picTruck).BeginInit();
            SuspendLayout();
            // 
            // grpRegistration
            // 
            grpRegistration.Controls.Add(radTruck);
            grpRegistration.Controls.Add(radVan);
            grpRegistration.Controls.Add(radCar);
            grpRegistration.Controls.Add(radDrone);
            grpRegistration.Controls.Add(radBike);
            grpRegistration.ForeColor = Color.Black;
            grpRegistration.Location = new Point(61, 58);
            grpRegistration.Name = "grpRegistration";
            grpRegistration.Size = new Size(420, 375);
            grpRegistration.TabIndex = 1;
            grpRegistration.TabStop = false;
            grpRegistration.Text = "Register New Vehicle";
            // 
            // radTruck
            // 
            radTruck.AutoSize = true;
            radTruck.Location = new Point(46, 292);
            radTruck.Name = "radTruck";
            radTruck.Size = new Size(344, 29);
            radTruck.TabIndex = 0;
            radTruck.Text = "Heavy-Duty Hydrogen Truck (Prefix: T-)";
            radTruck.UseVisualStyleBackColor = true;
            // 
            // radVan
            // 
            radVan.AutoSize = true;
            radVan.Location = new Point(46, 237);
            radVan.Name = "radVan";
            radVan.Size = new Size(210, 29);
            radVan.TabIndex = 0;
            radVan.Text = "Electric Van (Prefix: V-)";
            radVan.UseVisualStyleBackColor = true;
            // 
            // radCar
            // 
            radCar.AutoSize = true;
            radCar.Location = new Point(46, 182);
            radCar.Name = "radCar";
            radCar.Size = new Size(207, 29);
            radCar.TabIndex = 0;
            radCar.Text = "Electric Car (Prefix: C-)";
            radCar.UseVisualStyleBackColor = true;
            // 
            // radDrone
            // 
            radDrone.AutoSize = true;
            radDrone.Location = new Point(46, 127);
            radDrone.Name = "radDrone";
            radDrone.Size = new Size(169, 29);
            radDrone.TabIndex = 0;
            radDrone.Text = "Drone (Prefix D-)";
            radDrone.UseVisualStyleBackColor = true;
            // 
            // radBike
            // 
            radBike.AutoSize = true;
            radBike.Checked = true;
            radBike.Location = new Point(46, 72);
            radBike.Name = "radBike";
            radBike.Size = new Size(212, 29);
            radBike.TabIndex = 0;
            radBike.TabStop = true;
            radBike.Text = "Electric Bike (Prefix: B-)";
            radBike.UseVisualStyleBackColor = true;
            // 
            // lblgrpBack
            // 
            lblgrpBack.BorderStyle = BorderStyle.Fixed3D;
            lblgrpBack.ForeColor = Color.FromArgb(45, 62, 80);
            lblgrpBack.Location = new Point(34, 36);
            lblgrpBack.Name = "lblgrpBack";
            lblgrpBack.Size = new Size(475, 510);
            lblgrpBack.TabIndex = 0;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.FromArgb(39, 174, 96);
            btnRegister.FlatStyle = FlatStyle.Popup;
            btnRegister.ForeColor = Color.Black;
            btnRegister.Location = new Point(146, 448);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(236, 65);
            btnRegister.TabIndex = 2;
            btnRegister.Text = "[&Register && Generate ID]";
            btnRegister.UseVisualStyleBackColor = false;
            // 
            // btnAssignDriver
            // 
            btnAssignDriver.BackColor = Color.FromArgb(52, 152, 219);
            btnAssignDriver.FlatStyle = FlatStyle.Popup;
            btnAssignDriver.ForeColor = Color.Black;
            btnAssignDriver.Location = new Point(45, 563);
            btnAssignDriver.Name = "btnAssignDriver";
            btnAssignDriver.Size = new Size(210, 65);
            btnAssignDriver.TabIndex = 3;
            btnAssignDriver.Text = "[Assign/Change &Driver]";
            btnAssignDriver.UseVisualStyleBackColor = false;
            // 
            // btnManageCargo
            // 
            btnManageCargo.BackColor = Color.FromArgb(155, 89, 182);
            btnManageCargo.FlatStyle = FlatStyle.Popup;
            btnManageCargo.ForeColor = Color.Black;
            btnManageCargo.Location = new Point(292, 563);
            btnManageCargo.Name = "btnManageCargo";
            btnManageCargo.Size = new Size(210, 65);
            btnManageCargo.TabIndex = 4;
            btnManageCargo.Text = "[Manage &Cargo]";
            btnManageCargo.UseVisualStyleBackColor = false;
            // 
            // btnRemoveVehicle
            // 
            btnRemoveVehicle.BackColor = Color.FromArgb(192, 57, 43);
            btnRemoveVehicle.FlatStyle = FlatStyle.Popup;
            btnRemoveVehicle.ForeColor = Color.Black;
            btnRemoveVehicle.Location = new Point(539, 563);
            btnRemoveVehicle.Name = "btnRemoveVehicle";
            btnRemoveVehicle.Size = new Size(210, 65);
            btnRemoveVehicle.TabIndex = 5;
            btnRemoveVehicle.Text = "[Remove &Vehicle]";
            btnRemoveVehicle.UseVisualStyleBackColor = false;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.FromArgb(127, 140, 141);
            btnExit.FlatStyle = FlatStyle.Popup;
            btnExit.ForeColor = Color.Black;
            btnExit.Location = new Point(1033, 563);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(210, 65);
            btnExit.TabIndex = 7;
            btnExit.Text = "[&Exit Program]";
            btnExit.UseVisualStyleBackColor = false;
            // 
            // lstFleet
            // 
            lstFleet.ForeColor = Color.Black;
            lstFleet.FormattingEnabled = true;
            lstFleet.Location = new Point(526, 72);
            lstFleet.Name = "lstFleet";
            lstFleet.Size = new Size(300, 404);
            lstFleet.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(544, 37);
            label1.Name = "label1";
            label1.Size = new Size(265, 25);
            label1.TabIndex = 0;
            label1.Text = "Registered Fleet (Vehicle ID's)";
            // 
            // lblTotalCount
            // 
            lblTotalCount.AutoSize = true;
            lblTotalCount.ForeColor = Color.Black;
            lblTotalCount.Location = new Point(609, 492);
            lblTotalCount.Name = "lblTotalCount";
            lblTotalCount.Size = new Size(135, 25);
            lblTotalCount.TabIndex = 0;
            lblTotalCount.Text = "Total Vehicles: 0";
            // 
            // grpVehicleDetails
            // 
            grpVehicleDetails.Controls.Add(lblFuelStatus);
            grpVehicleDetails.Controls.Add(lblFuelPercent);
            grpVehicleDetails.Controls.Add(lblDisplayMaxPayload);
            grpVehicleDetails.Controls.Add(label2);
            grpVehicleDetails.Controls.Add(label9);
            grpVehicleDetails.Controls.Add(label15);
            grpVehicleDetails.Controls.Add(lblDisplayFuelType);
            grpVehicleDetails.Controls.Add(lblDisplayPayload);
            grpVehicleDetails.Controls.Add(lblDisplayDriver);
            grpVehicleDetails.Controls.Add(lblDisplayType);
            grpVehicleDetails.Controls.Add(lblDisplayID);
            grpVehicleDetails.Controls.Add(label8);
            grpVehicleDetails.Controls.Add(label7);
            grpVehicleDetails.Controls.Add(label6);
            grpVehicleDetails.Controls.Add(label5);
            grpVehicleDetails.Controls.Add(label4);
            grpVehicleDetails.Controls.Add(label3);
            grpVehicleDetails.Controls.Add(picBike);
            grpVehicleDetails.Controls.Add(picDrone);
            grpVehicleDetails.Controls.Add(picCar);
            grpVehicleDetails.Controls.Add(picVan);
            grpVehicleDetails.Controls.Add(picTruck);
            grpVehicleDetails.ForeColor = Color.Black;
            grpVehicleDetails.Location = new Point(846, 58);
            grpVehicleDetails.Name = "grpVehicleDetails";
            grpVehicleDetails.Size = new Size(420, 488);
            grpVehicleDetails.TabIndex = 0;
            grpVehicleDetails.TabStop = false;
            grpVehicleDetails.Text = "Selected Vehicle Details";
            // 
            // lblFuelStatus
            // 
            lblFuelStatus.AutoSize = true;
            lblFuelStatus.Location = new Point(152, 434);
            lblFuelStatus.Name = "lblFuelStatus";
            lblFuelStatus.Size = new Size(64, 25);
            lblFuelStatus.TabIndex = 0;
            lblFuelStatus.Text = "[HERE]";
            // 
            // lblFuelPercent
            // 
            lblFuelPercent.AutoSize = true;
            lblFuelPercent.Location = new Point(323, 434);
            lblFuelPercent.Name = "lblFuelPercent";
            lblFuelPercent.Size = new Size(64, 25);
            lblFuelPercent.TabIndex = 0;
            lblFuelPercent.Text = "[HERE]";
            // 
            // lblDisplayMaxPayload
            // 
            lblDisplayMaxPayload.AutoSize = true;
            lblDisplayMaxPayload.Location = new Point(264, 88);
            lblDisplayMaxPayload.Name = "lblDisplayMaxPayload";
            lblDisplayMaxPayload.Size = new Size(64, 25);
            lblDisplayMaxPayload.TabIndex = 0;
            lblDisplayMaxPayload.Text = "[HERE]";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(239, 40);
            label2.Name = "label2";
            label2.Size = new Size(116, 25);
            label2.TabIndex = 0;
            label2.Text = "Max Payload:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(22, 434);
            label9.Name = "label9";
            label9.Size = new Size(124, 25);
            label9.TabIndex = 0;
            label9.Text = "FUEL STATUS: ";
            // 
            // label15
            // 
            label15.BorderStyle = BorderStyle.FixedSingle;
            label15.Location = new Point(12, 420);
            label15.Name = "label15";
            label15.Size = new Size(396, 56);
            label15.TabIndex = 9;
            // 
            // lblDisplayFuelType
            // 
            lblDisplayFuelType.AutoSize = true;
            lblDisplayFuelType.Location = new Point(323, 386);
            lblDisplayFuelType.Name = "lblDisplayFuelType";
            lblDisplayFuelType.Size = new Size(64, 25);
            lblDisplayFuelType.TabIndex = 0;
            lblDisplayFuelType.Text = "[HERE]";
            // 
            // lblDisplayPayload
            // 
            lblDisplayPayload.AutoSize = true;
            lblDisplayPayload.Location = new Point(323, 346);
            lblDisplayPayload.Name = "lblDisplayPayload";
            lblDisplayPayload.Size = new Size(64, 25);
            lblDisplayPayload.TabIndex = 0;
            lblDisplayPayload.Text = "[HERE]";
            // 
            // lblDisplayDriver
            // 
            lblDisplayDriver.AutoSize = true;
            lblDisplayDriver.Location = new Point(323, 306);
            lblDisplayDriver.Name = "lblDisplayDriver";
            lblDisplayDriver.Size = new Size(64, 25);
            lblDisplayDriver.TabIndex = 0;
            lblDisplayDriver.Text = "[HERE]";
            // 
            // lblDisplayType
            // 
            lblDisplayType.AutoSize = true;
            lblDisplayType.Location = new Point(323, 266);
            lblDisplayType.Name = "lblDisplayType";
            lblDisplayType.Size = new Size(64, 25);
            lblDisplayType.TabIndex = 0;
            lblDisplayType.Text = "[HERE]";
            // 
            // lblDisplayID
            // 
            lblDisplayID.AutoSize = true;
            lblDisplayID.Location = new Point(323, 226);
            lblDisplayID.Name = "lblDisplayID";
            lblDisplayID.Size = new Size(64, 25);
            lblDisplayID.TabIndex = 0;
            lblDisplayID.Text = "[HERE]";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(9, 386);
            label8.Name = "label8";
            label8.Size = new Size(130, 25);
            label8.TabIndex = 0;
            label8.Text = "Fuel or Battery:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(9, 346);
            label7.Name = "label7";
            label7.Size = new Size(78, 25);
            label7.TabIndex = 0;
            label7.Text = "Payload:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(9, 306);
            label6.Name = "label6";
            label6.Size = new Size(141, 25);
            label6.TabIndex = 0;
            label6.Text = "Assigned Driver:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(9, 266);
            label5.Name = "label5";
            label5.Size = new Size(53, 25);
            label5.TabIndex = 0;
            label5.Text = "Type:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(9, 226);
            label4.Name = "label4";
            label4.Size = new Size(34, 25);
            label4.TabIndex = 0;
            label4.Text = "ID:";
            // 
            // label3
            // 
            label3.BorderStyle = BorderStyle.Fixed3D;
            label3.Location = new Point(6, 208);
            label3.Name = "label3";
            label3.Size = new Size(406, 3);
            label3.TabIndex = 0;
            // 
            // picBike
            // 
            picBike.BorderStyle = BorderStyle.Fixed3D;
            picBike.Image = (Image)resources.GetObject("picBike.Image");
            picBike.Location = new Point(22, 40);
            picBike.Name = "picBike";
            picBike.Size = new Size(150, 150);
            picBike.SizeMode = PictureBoxSizeMode.Zoom;
            picBike.TabIndex = 0;
            picBike.TabStop = false;
            // 
            // picDrone
            // 
            picDrone.BorderStyle = BorderStyle.Fixed3D;
            picDrone.Image = (Image)resources.GetObject("picDrone.Image");
            picDrone.Location = new Point(22, 40);
            picDrone.Name = "picDrone";
            picDrone.Size = new Size(150, 150);
            picDrone.SizeMode = PictureBoxSizeMode.Zoom;
            picDrone.TabIndex = 22;
            picDrone.TabStop = false;
            // 
            // picCar
            // 
            picCar.BorderStyle = BorderStyle.Fixed3D;
            picCar.Image = (Image)resources.GetObject("picCar.Image");
            picCar.Location = new Point(22, 40);
            picCar.Name = "picCar";
            picCar.Size = new Size(150, 150);
            picCar.SizeMode = PictureBoxSizeMode.Zoom;
            picCar.TabIndex = 23;
            picCar.TabStop = false;
            // 
            // picVan
            // 
            picVan.BorderStyle = BorderStyle.Fixed3D;
            picVan.Image = (Image)resources.GetObject("picVan.Image");
            picVan.Location = new Point(22, 40);
            picVan.Name = "picVan";
            picVan.Size = new Size(150, 150);
            picVan.SizeMode = PictureBoxSizeMode.Zoom;
            picVan.TabIndex = 24;
            picVan.TabStop = false;
            // 
            // picTruck
            // 
            picTruck.BorderStyle = BorderStyle.Fixed3D;
            picTruck.Image = (Image)resources.GetObject("picTruck.Image");
            picTruck.Location = new Point(22, 40);
            picTruck.Name = "picTruck";
            picTruck.Size = new Size(150, 150);
            picTruck.SizeMode = PictureBoxSizeMode.Zoom;
            picTruck.TabIndex = 25;
            picTruck.TabStop = false;
            // 
            // btnManageFuel
            // 
            btnManageFuel.BackColor = Color.FromArgb(243, 156, 18);
            btnManageFuel.FlatStyle = FlatStyle.Popup;
            btnManageFuel.ForeColor = Color.Black;
            btnManageFuel.Location = new Point(786, 563);
            btnManageFuel.Name = "btnManageFuel";
            btnManageFuel.Size = new Size(210, 65);
            btnManageFuel.TabIndex = 6;
            btnManageFuel.Text = "[Manage &Fuel/Battery]";
            btnManageFuel.UseVisualStyleBackColor = false;
            // 
            // frmFleetDashboard
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(222, 245, 233);
            ClientSize = new Size(1278, 644);
            Controls.Add(btnManageFuel);
            Controls.Add(grpVehicleDetails);
            Controls.Add(lblTotalCount);
            Controls.Add(label1);
            Controls.Add(lstFleet);
            Controls.Add(btnExit);
            Controls.Add(btnRemoveVehicle);
            Controls.Add(btnManageCargo);
            Controls.Add(btnAssignDriver);
            Controls.Add(btnRegister);
            Controls.Add(grpRegistration);
            Controls.Add(lblgrpBack);
            ForeColor = Color.Black;
            Name = "frmFleetDashboard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EcoLink: Operations Command";
            Load += Form1_Load;
            grpRegistration.ResumeLayout(false);
            grpRegistration.PerformLayout();
            grpVehicleDetails.ResumeLayout(false);
            grpVehicleDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picBike).EndInit();
            ((System.ComponentModel.ISupportInitialize)picDrone).EndInit();
            ((System.ComponentModel.ISupportInitialize)picCar).EndInit();
            ((System.ComponentModel.ISupportInitialize)picVan).EndInit();
            ((System.ComponentModel.ISupportInitialize)picTruck).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grpRegistration;
        private RadioButton radTruck;
        private RadioButton radVan;
        private RadioButton radCar;
        private RadioButton radDrone;
        private RadioButton radBike;
        private Label lblgrpBack;
        private Button btnRegister;
        private Button btnAssignDriver;
        private Button btnManageCargo;
        private Button btnRemoveVehicle;
        private Button btnExit;
        private ListBox lstFleet;
        private Label label1;
        private Label lblTotalCount;
        private GroupBox grpVehicleDetails;
        private PictureBox picBike;
        private Label label3;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label8;
        private Label label7;
        private Label lblDisplayFuelType;
        private Label lblDisplayPayload;
        private Label lblDisplayDriver;
        private Label lblDisplayType;
        private Label lblDisplayID;
        private Button btnManageFuel;
        private Label label15;
        private Label label9;
        private Label label2;
        private PictureBox picDrone;
        private PictureBox picCar;
        private PictureBox picVan;
        private PictureBox picTruck;
        private Label lblDisplayMaxPayload;
        private Label lblFuelStatus;
        private Label lblFuelPercent;
    }
}
