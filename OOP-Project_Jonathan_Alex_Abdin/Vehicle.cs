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
        // Properties
        public string vehicleID { get; set; }
        public double vehicleSize { get; set; }
        public double maxCapacity { get; set; }
        public double currentLoad { get; set; }

        // Methods
        public void addPackage(Package pkg) 
        {
        }
        public double getRemainingCapacity() {
            return 0.1;
        }
        public double getRemainingSize() 
        {
            return 0.1;
        }
    }
    //Creating ElectricVehicle class 
    public class ElectricVehicle : Vehicle 
    {
        //Methods
        public double checkBatteryLevel() 
        {
            return 0.1;
        }
    }
    //Creating HydrogenVehicle class 
    public class HydrogenVehicle : Vehicle
    {
        //Methods
        public double checkHydrogenLevel()
        {
            return 0.1;
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
