namespace OOP_Project_Jonathan_Alex_Abdin
{
    partial class frmManageCargo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManageCargo));
            label1 = new Label();
            picBike = new PictureBox();
            picDrone = new PictureBox();
            picCar = new PictureBox();
            picVan = new PictureBox();
            picTruck = new PictureBox();
            lblVehicleDetails = new Label();
            label2 = new Label();
            lblCurrentWeight = new Label();
            label4 = new Label();
            lblMaxWeight = new Label();
            label6 = new Label();
            prgCapacity = new ProgressBar();
            groupBox1 = new GroupBox();
            lstWarehouse = new ListBox();
            groupBox2 = new GroupBox();
            lstVehicleCargo = new ListBox();
            btnAddCargo = new Button();
            btnRemoveCargo = new Button();
            btnConfimCargo = new Button();
            btnCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)picBike).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picDrone).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picCar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picVan).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picTruck).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(227, 36);
            label1.Name = "label1";
            label1.Size = new Size(353, 54);
            label1.TabIndex = 1;
            label1.Text = "Loading Cargo for:";
            // 
            // picBike
            // 
            picBike.BackColor = Color.White;
            picBike.BorderStyle = BorderStyle.Fixed3D;
            picBike.Image = (Image)resources.GetObject("picBike.Image");
            picBike.Location = new Point(43, 36);
            picBike.Name = "picBike";
            picBike.Size = new Size(150, 150);
            picBike.SizeMode = PictureBoxSizeMode.Zoom;
            picBike.TabIndex = 2;
            picBike.TabStop = false;
            // 
            // picDrone
            // 
            picDrone.BackColor = Color.White;
            picDrone.BorderStyle = BorderStyle.Fixed3D;
            picDrone.Image = (Image)resources.GetObject("picDrone.Image");
            picDrone.Location = new Point(43, 36);
            picDrone.Name = "picDrone";
            picDrone.Size = new Size(150, 150);
            picDrone.SizeMode = PictureBoxSizeMode.Zoom;
            picDrone.TabIndex = 23;
            picDrone.TabStop = false;
            // 
            // picCar
            // 
            picCar.BackColor = Color.White;
            picCar.BorderStyle = BorderStyle.Fixed3D;
            picCar.Image = (Image)resources.GetObject("picCar.Image");
            picCar.Location = new Point(43, 36);
            picCar.Name = "picCar";
            picCar.Size = new Size(150, 150);
            picCar.SizeMode = PictureBoxSizeMode.Zoom;
            picCar.TabIndex = 24;
            picCar.TabStop = false;
            // 
            // picVan
            // 
            picVan.BackColor = Color.White;
            picVan.BorderStyle = BorderStyle.Fixed3D;
            picVan.Image = (Image)resources.GetObject("picVan.Image");
            picVan.Location = new Point(43, 36);
            picVan.Name = "picVan";
            picVan.Size = new Size(150, 150);
            picVan.SizeMode = PictureBoxSizeMode.Zoom;
            picVan.TabIndex = 25;
            picVan.TabStop = false;
            // 
            // picTruck
            // 
            picTruck.BackColor = Color.White;
            picTruck.BorderStyle = BorderStyle.Fixed3D;
            picTruck.Image = (Image)resources.GetObject("picTruck.Image");
            picTruck.Location = new Point(43, 36);
            picTruck.Name = "picTruck";
            picTruck.Size = new Size(150, 150);
            picTruck.SizeMode = PictureBoxSizeMode.Zoom;
            picTruck.TabIndex = 26;
            picTruck.TabStop = false;
            // 
            // lblVehicleDetails
            // 
            lblVehicleDetails.AutoSize = true;
            lblVehicleDetails.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblVehicleDetails.Location = new Point(609, 36);
            lblVehicleDetails.Name = "lblVehicleDetails";
            lblVehicleDetails.Size = new Size(208, 54);
            lblVehicleDetails.TabIndex = 27;
            lblVehicleDetails.Text = "[ Vehicle ]";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(210, 104);
            label2.Name = "label2";
            label2.Size = new Size(253, 45);
            label2.TabIndex = 28;
            label2.Text = "Current Weight: ";
            // 
            // lblCurrentWeight
            // 
            lblCurrentWeight.AutoSize = true;
            lblCurrentWeight.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCurrentWeight.Location = new Point(450, 104);
            lblCurrentWeight.Name = "lblCurrentWeight";
            lblCurrentWeight.Size = new Size(76, 45);
            lblCurrentWeight.TabIndex = 29;
            lblCurrentWeight.Text = "0kg";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(568, 104);
            label4.Name = "label4";
            label4.Size = new Size(126, 45);
            label4.TabIndex = 30;
            label4.Text = " / Max: ";
            // 
            // lblMaxWeight
            // 
            lblMaxWeight.AutoSize = true;
            lblMaxWeight.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMaxWeight.Location = new Point(680, 104);
            lblMaxWeight.Name = "lblMaxWeight";
            lblMaxWeight.Size = new Size(76, 45);
            lblMaxWeight.TabIndex = 31;
            lblMaxWeight.Text = "0kg";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(724, 170);
            label6.Name = "label6";
            label6.Size = new Size(83, 45);
            label6.TabIndex = 32;
            label6.Text = "(0%)";
            // 
            // prgCapacity
            // 
            prgCapacity.Location = new Point(817, 181);
            prgCapacity.Name = "prgCapacity";
            prgCapacity.Size = new Size(484, 34);
            prgCapacity.TabIndex = 33;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.FromArgb(210, 180, 222);
            groupBox1.Controls.Add(lstWarehouse);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(43, 221);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(473, 364);
            groupBox1.TabIndex = 34;
            groupBox1.TabStop = false;
            groupBox1.Text = "Available Packages (Bulk Warehouse)";
            // 
            // lstWarehouse
            // 
            lstWarehouse.FormattingEnabled = true;
            lstWarehouse.Location = new Point(20, 48);
            lstWarehouse.Name = "lstWarehouse";
            lstWarehouse.Size = new Size(430, 292);
            lstWarehouse.TabIndex = 35;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.FromArgb(210, 180, 222);
            groupBox2.Controls.Add(lstVehicleCargo);
            groupBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(817, 221);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(473, 364);
            groupBox2.TabIndex = 36;
            groupBox2.TabStop = false;
            groupBox2.Text = "Currently Loaded (Vehicle Inventory)";
            // 
            // lstVehicleCargo
            // 
            lstVehicleCargo.FormattingEnabled = true;
            lstVehicleCargo.Location = new Point(20, 48);
            lstVehicleCargo.Name = "lstVehicleCargo";
            lstVehicleCargo.Size = new Size(430, 292);
            lstVehicleCargo.TabIndex = 35;
            // 
            // btnAddCargo
            // 
            btnAddCargo.BackColor = Color.FromArgb(155, 89, 182);
            btnAddCargo.FlatStyle = FlatStyle.Popup;
            btnAddCargo.Font = new Font("Segoe UI", 36F, FontStyle.Bold);
            btnAddCargo.Location = new Point(541, 286);
            btnAddCargo.Name = "btnAddCargo";
            btnAddCargo.Size = new Size(251, 107);
            btnAddCargo.TabIndex = 37;
            btnAddCargo.Text = ">";
            btnAddCargo.UseVisualStyleBackColor = false;
            btnAddCargo.Click += btnAddCargo_Click;
            // 
            // btnRemoveCargo
            // 
            btnRemoveCargo.BackColor = Color.FromArgb(155, 89, 182);
            btnRemoveCargo.FlatStyle = FlatStyle.Popup;
            btnRemoveCargo.Font = new Font("Segoe UI", 36F, FontStyle.Bold);
            btnRemoveCargo.Location = new Point(541, 425);
            btnRemoveCargo.Name = "btnRemoveCargo";
            btnRemoveCargo.Size = new Size(251, 107);
            btnRemoveCargo.TabIndex = 38;
            btnRemoveCargo.Text = "<";
            btnRemoveCargo.UseVisualStyleBackColor = false;
            btnRemoveCargo.Click += btnRemoveCargo_Click;
            // 
            // btnConfimCargo
            // 
            btnConfimCargo.BackColor = Color.FromArgb(155, 89, 182);
            btnConfimCargo.FlatStyle = FlatStyle.Popup;
            btnConfimCargo.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConfimCargo.Location = new Point(43, 608);
            btnConfimCargo.Name = "btnConfimCargo";
            btnConfimCargo.Size = new Size(826, 89);
            btnConfimCargo.TabIndex = 39;
            btnConfimCargo.Text = "[Confirm && Update Fleet]";
            btnConfimCargo.UseVisualStyleBackColor = false;
            btnConfimCargo.Click += btnConfimCargo_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(213, 216, 220);
            btnCancel.FlatStyle = FlatStyle.Popup;
            btnCancel.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCancel.Location = new Point(916, 608);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(376, 89);
            btnCancel.TabIndex = 40;
            btnCancel.Text = "[Cancel && Close]";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // frmManageCargo
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(210, 180, 222);
            ClientSize = new Size(1338, 728);
            Controls.Add(btnCancel);
            Controls.Add(btnConfimCargo);
            Controls.Add(btnRemoveCargo);
            Controls.Add(btnAddCargo);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(prgCapacity);
            Controls.Add(label6);
            Controls.Add(lblMaxWeight);
            Controls.Add(label4);
            Controls.Add(lblCurrentWeight);
            Controls.Add(label2);
            Controls.Add(lblVehicleDetails);
            Controls.Add(label1);
            Controls.Add(picBike);
            Controls.Add(picDrone);
            Controls.Add(picCar);
            Controls.Add(picVan);
            Controls.Add(picTruck);
            Name = "frmManageCargo";
            Text = "Cargo Loading Management - EcoLink Hub";
            Load += frmManageCargo_Load;
            ((System.ComponentModel.ISupportInitialize)picBike).EndInit();
            ((System.ComponentModel.ISupportInitialize)picDrone).EndInit();
            ((System.ComponentModel.ISupportInitialize)picCar).EndInit();
            ((System.ComponentModel.ISupportInitialize)picVan).EndInit();
            ((System.ComponentModel.ISupportInitialize)picTruck).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox picBike;
        private PictureBox picDrone;
        private PictureBox picCar;
        private PictureBox picVan;
        private PictureBox picTruck;
        private Label lblVehicleDetails;
        private Label label2;
        private Label lblCurrentWeight;
        private Label label4;
        private Label lblMaxWeight;
        private Label label6;
        private ProgressBar prgCapacity;
        private GroupBox groupBox1;
        private ListBox lstWarehouse;
        private GroupBox groupBox2;
        private ListBox lstVehicleCargo;
        private Button btnAddCargo;
        private Button btnRemoveCargo;
        private Button btnConfimCargo;
        private Button btnCancel;
    }
}