namespace OOP_Project_Jonathan_Alex_Abdin
{
    partial class frmAssignDriver
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
            label1 = new Label();
            lblVehicleDetails = new Label();
            label2 = new Label();
            lblDriverSelection = new Label();
            grpDriverSelection = new GroupBox();
            cboDrivers = new ComboBox();
            label3 = new Label();
            btnConfirm = new Button();
            btnCancel = new Button();
            grpDriverSelection.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(38, 48);
            label1.Name = "label1";
            label1.Size = new Size(382, 54);
            label1.TabIndex = 0;
            label1.Text = "Assigning Driver to: ";
            // 
            // lblVehicleDetails
            // 
            lblVehicleDetails.AutoSize = true;
            lblVehicleDetails.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblVehicleDetails.Location = new Point(436, 48);
            lblVehicleDetails.Name = "lblVehicleDetails";
            lblVehicleDetails.Size = new Size(208, 54);
            lblVehicleDetails.TabIndex = 0;
            lblVehicleDetails.Text = "[ Vehicle ]";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(185, 115);
            label2.Name = "label2";
            label2.Size = new Size(235, 45);
            label2.TabIndex = 0;
            label2.Text = "Current Driver: ";
            // 
            // lblDriverSelection
            // 
            lblDriverSelection.AutoSize = true;
            lblDriverSelection.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDriverSelection.Location = new Point(426, 115);
            lblDriverSelection.Name = "lblDriverSelection";
            lblDriverSelection.Size = new Size(98, 45);
            lblDriverSelection.TabIndex = 0;
            lblDriverSelection.Text = "None";
            // 
            // grpDriverSelection
            // 
            grpDriverSelection.Controls.Add(cboDrivers);
            grpDriverSelection.Controls.Add(label3);
            grpDriverSelection.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grpDriverSelection.ForeColor = SystemColors.ControlText;
            grpDriverSelection.Location = new Point(38, 177);
            grpDriverSelection.Name = "grpDriverSelection";
            grpDriverSelection.Size = new Size(606, 179);
            grpDriverSelection.TabIndex = 3;
            grpDriverSelection.TabStop = false;
            grpDriverSelection.Text = "Driver Selection";
            // 
            // cboDrivers
            // 
            cboDrivers.BackColor = Color.White;
            cboDrivers.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboDrivers.FormattingEnabled = true;
            cboDrivers.Location = new Point(6, 82);
            cboDrivers.Name = "cboDrivers";
            cboDrivers.Size = new Size(581, 33);
            cboDrivers.TabIndex = 0;
            cboDrivers.Text = "Select and Available Driver from this list.";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(6, 41);
            label3.Name = "label3";
            label3.Size = new Size(246, 38);
            label3.TabIndex = 0;
            label3.Text = "Available Drivers:";
            // 
            // btnConfirm
            // 
            btnConfirm.BackColor = Color.FromArgb(52, 152, 219);
            btnConfirm.FlatStyle = FlatStyle.Popup;
            btnConfirm.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConfirm.Location = new Point(38, 374);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(280, 79);
            btnConfirm.TabIndex = 1;
            btnConfirm.Text = "[Confirm Assignment]";
            btnConfirm.UseVisualStyleBackColor = false;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(213, 216, 220);
            btnCancel.FlatStyle = FlatStyle.Popup;
            btnCancel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnCancel.Location = new Point(364, 374);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(280, 79);
            btnCancel.TabIndex = 2;
            btnCancel.Text = "[Cancel && Close]";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // frmAssignDriver
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(174, 214, 241);
            ClientSize = new Size(708, 515);
            Controls.Add(btnCancel);
            Controls.Add(btnConfirm);
            Controls.Add(grpDriverSelection);
            Controls.Add(lblDriverSelection);
            Controls.Add(label2);
            Controls.Add(lblVehicleDetails);
            Controls.Add(label1);
            Name = "frmAssignDriver";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Driver Assignment Command - EcoLink Hub";
            Load += frmAssignDriver_Load;
            grpDriverSelection.ResumeLayout(false);
            grpDriverSelection.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblVehicleDetails;
        private Label label2;
        private Label lblDriverSelection;
        private GroupBox grpDriverSelection;
        private ComboBox cboDrivers;
        private Button btnConfirm;
        private Button btnCancel;
        private Label label3;
    }
}