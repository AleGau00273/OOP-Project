using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Project_Jonathan_Alex_Abdin
{
    // Creating Driver Assignment Form
    // Features: [F-05], [F-07], [F-08]
    public partial class frmAssignDriver : Form
    {
        // Properties and lists
        private Vehicle _selectedVehicle;

        // Methods

        // Passing the vehicle reference for cross-form editing [F-05]
        public frmAssignDriver(Vehicle vehicleToEdit)
        {
            InitializeComponent();
            _selectedVehicle = vehicleToEdit;
        }

        private void frmAssignDriver_Load(object sender, EventArgs e)
        {
            // Displaying current vehicle details passed from Form 1 (frmFleetDashboard)
            lblVehicleDetails.Text = _selectedVehicle.VehicleID;
            lblDriverSelection.Text = _selectedVehicle.DriverName;

            // Loading the combo box with drivers from our static pool [F-08]
            cboDrivers.Items.Clear();
            foreach (string? driver in FleetManager.AvailableDrivers)
            {
                if (driver != null)
                {
                    cboDrivers.Items.Add(driver);
                }
            }
        }

        // Logic for assigning the driver and managing the shared pool
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (cboDrivers.SelectedIndex != -1)
            {
                string newDriver = cboDrivers.SelectedItem?.ToString() ?? "Unassigned";

                // If we are replacing an existing driver, they go back to the top of the pool
                if (_selectedVehicle.DriverName != "Unassigned")
                {
                        FleetManager.AvailableDrivers.Insert(0, _selectedVehicle.DriverName);
                }

                // Updating the vehicle object and removing the new driver from availability
                _selectedVehicle.DriverName = newDriver;
                FleetManager.AvailableDrivers.Remove(newDriver);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}