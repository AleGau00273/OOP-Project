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
    // Creating Cargo Management Form
    // Features: [F-04], [F-06], [F-08]
    public partial class frmManageCargo : Form
    {
        // Properties and lists
        private Vehicle _selectedVehicle;
        private List<Package> _sessionPackages = new List<Package>();

        // Methods

        public frmManageCargo(Vehicle vehicle)
        {
            InitializeComponent();
            _selectedVehicle = vehicle;
        }

        private void frmManageCargo_Load(object sender, EventArgs e)
        {
            lblVehicleDetails.Text = _selectedVehicle.VehicleID;
            UpdateCargoDisplay();
            UpdateVehicleImage(_selectedVehicle);
            RefreshVehicleCargoList();
            RefreshWarehouseList();
        }

        // Standardizing the list display for a clean UI
        private string GetPackageDisplayName(Package pkg) => $"{pkg.PackageID} | {pkg.Weight}kg - {pkg.Description}";

        private void RefreshWarehouseList()
        {
            lstWarehouse.Items.Clear();
            foreach (var pkg in frmFleetDashboard.Warehouse) lstWarehouse.Items.Add(GetPackageDisplayName(pkg));
        }

        private void RefreshVehicleCargoList()
        {
            lstVehicleCargo.Items.Clear();
            foreach (var pkg in _selectedVehicle.LoadedPackages) lstVehicleCargo.Items.Add(GetPackageDisplayName(pkg));
        }

        private void UpdateCargoDisplay()
        {
            lblCurrentWeight.Text = $"{_selectedVehicle.CurrentWeightLoad}kg";
            lblMaxWeight.Text = $"{_selectedVehicle.MaxCapacity}kg";

            double percent = (_selectedVehicle.CurrentWeightLoad / _selectedVehicle.MaxCapacity) * 100;
            label6.Text = $"({(int)percent}%)";
            prgCapacity.Value = (int)Math.Min(percent, 100);
        }

        // Attempting to add cargo via overloaded operator [F-04]
        private void btnAddCargo_Click(object sender, EventArgs e)
        {
            if (lstWarehouse.SelectedIndex == -1) return;
            int index = lstWarehouse.SelectedIndex;
            Package selectedPkg = frmFleetDashboard.Warehouse[index];

            try
            {
                // Using the overloaded + operator [F-04]
                _selectedVehicle = _selectedVehicle + selectedPkg;

                // Tracking the move for the cancel rollback logic
                _sessionPackages.Add(selectedPkg);
                frmFleetDashboard.Warehouse.RemoveAt(index);

                RefreshVehicleCargoList();
                RefreshWarehouseList();
                UpdateCargoDisplay();
            }
            catch (InvalidOperationException ex)
            {
                // Catching weight violations [F-08]
                MessageBox.Show(ex.Message, "Weight Limit Reached", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnRemoveCargo_Click(object sender, EventArgs e)
        {
            if (lstVehicleCargo.SelectedIndex == -1) return;
            int index = lstVehicleCargo.SelectedIndex;
            Package pkgToRemove = _selectedVehicle.LoadedPackages[index];

            // Reversing the loads manually and returning cargo to the top of the warehouse pool
            _selectedVehicle.CurrentWeightLoad -= pkgToRemove.Weight;
            _selectedVehicle.CurrentSizeLoad -= pkgToRemove.PackageSize;

            frmFleetDashboard.Warehouse.Insert(0, pkgToRemove);
            _selectedVehicle.LoadedPackages.RemoveAt(index);

            RefreshVehicleCargoList();
            RefreshWarehouseList();
            UpdateCargoDisplay();
        }

        private void btnConfimCargo_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        // Logic for cancelling changes and rolling back the session [F-08]
        private void btnCancel_Click(object sender, EventArgs e)
        {
            // Reverse loop to safely unload items added in this window
            for (int i = _sessionPackages.Count - 1; i >= 0; i--)
            {
                Package pkg = _sessionPackages[i];
                _selectedVehicle.CurrentWeightLoad -= pkg.Weight;
                _selectedVehicle.CurrentSizeLoad -= pkg.PackageSize;
                _selectedVehicle.LoadedPackages.Remove(pkg);
                frmFleetDashboard.Warehouse.Add(pkg);
            }
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void UpdateVehicleImage(Vehicle v)
        {
            picBike.Visible = v is ElectricBike;
            picDrone.Visible = v is Drone;
            picCar.Visible = v is ElectricCar;
            picVan.Visible = v is ElectricVan;
            picTruck.Visible = v is HeavydutyHydrogenTruck;
        }
    }
}