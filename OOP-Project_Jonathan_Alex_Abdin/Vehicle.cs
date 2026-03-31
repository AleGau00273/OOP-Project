using System;
using System.Collections.Generic;
using System.IO.Packaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Project_Jonathan_Alex_Abdin
{
    // Creating Main Vehicle Class (Abstract)
    public abstract class Vehicle
    {
        // Properties and lists
        List<ElectricVehicle> ElectricVehiclesList = new List<ElectricVehicle>();
        List<HydrogenVehicle> HydrogenVehiclesList = new List<HydrogenVehicle>();

        public string VehicleID { get; set; }
        public double VehicleSize { get; set; }
        public double MaxCapacity { get; set; }
        public double CurrentWeightLoad { get; set; }
        public double CurrentSizeLoad { get; set; }

        // Methods
        public void addPackage(Package pkg) 
        {
        }
        public double getRemainingCapacity() {
            return MaxCapacity - CurrentWeightLoad;
        }
        public double getRemainingSize() 
        {
            return VehicleSize - CurrentSizeLoad;
        }
    }
    //Creating ElectricVehicle class 
    public class ElectricVehicle : Vehicle 
    {
        // Properties
        public double BatteryLevel { get; set; }
        //Methods
        public double checkBatteryLevel() 
        {
            return BatteryLevel;
        }
    }
    //Creating HydrogenVehicle class 
    public class HydrogenVehicle : Vehicle
    {
        // Properties
        public double HydrogenLevel { get; set; }
        //Methods
        public double checkHydrogenLevel()
        {
            return HydrogenLevel;
        }
    }

    //Creating Drone class (Sealed)
    public sealed class Drone : ElectricVehicle 
    {
        // Methods
        public bool checkAirSpace() 
        {
            return true;
        }
    }
    //Creating ElectricCar class (Sealed)
    public sealed class ElectricCar : ElectricVehicle
    {
    }

    //Creating ElectricVan class (Sealed)
    public sealed class ElectricVan : ElectricVehicle
    {
    }

    //Creating HeavydutyHydrogenTruck class (Sealed)
    public sealed class HeavydutyHydrogenTruck : HydrogenVehicle 
    {
    }
}
