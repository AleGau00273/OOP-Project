using System;
using System.Collections.Generic;
using System.IO.Packaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Project_Jonathan_Alex_Abdin
{
    // Creating Main Vehicle Class (Abstract)

    public abstract class Vehicle : IComparable<Vehicle> //Added IComparable for sorting by MaxCapacity
    {
        // Properties and lists
        List<ElectricVehicle> ElectricVehiclesList = new List<ElectricVehicle>();
        List<HydrogenVehicle> HydrogenVehiclesList = new List<HydrogenVehicle>();

        public string DriverName { get; set; }
        public string VehicleID { get; set; }
        public double VehicleSize { get; set; }
        public double MaxCapacity { get; set; }
        public double CurrentWeightLoad { get; set; }
        public double CurrentSizeLoad { get; set; }

        //Jonathan: IComparable Implementation
        //Sorting Logic(IComparable)
        //Compares the current vehicle's MaxCapacity with another vehicle's MaxCapacity
        //Returns -1 if this is smaller, 1 if larger, and 0 if they are equal.
        //This fulfills the requirement to sort the fleet by capacity.
        public int CompareTo(Vehicle other)
        {
            if (other == null) return 1;
            //Sorting based on the MaxCapacity property
            return this.MaxCapacity.CompareTo(other.MaxCapacity);
        }

        //Jonathan: Operator Overloading (Vehicle + Package)
        //Throws Exception for Member 3 (Alex) to catch in the UI
        //Overloads the '+' operator to allow the syntax 'Vehicle + Package'.
        //Before adding the package, it validates if the vehicle has enough capacity.
        public static Vehicle operator +(Vehicle v, Package p)
        {
            //Logical check: Current load + New Package weight vs. MAx Allowed.
            if (v.CurrentWeightLoad + p.Weight > v.MaxCapacity)
            {
                //Throws an exception to catch in the UI and prevent overloading the vehicle.
                //This prevents the application from processing invalid data.
                throw new InvalidOperationException($"Capacity Exceeded on {v.VehicleID}!");
            }

            //if weight is within limits, proceed to add the package.
            v.addPackage(p);
            return v;
        }

        //Jonathan: Method Overloading
        //Overload 1: Accepts a package object.
        //Automatically extracts the weight and size from the object.
        public void Load(Package pkg)
        {
            this.CurrentWeightLoad += pkg.Weight;
            this.CurrentSizeLoad += pkg.PackageSize;
        }

        //Overload 2: Accepts raw double values for weight and size.
        //Useful for manual load adjustments or if a package object isn't present.
        public void Load(double weight, double size)
        {
            this.CurrentWeightLoad += weight;
            this.CurrentSizeLoad += size;
        }
        // Methods
        public void addPackage(Package pkg)
        {
            //this method should be calling the Load(pkg) method to update the weight
            //Once the operator overload (+) approves the transaction.

            //this.Load(pkg); this might do?
        }
        public double getRemainingCapacity()
        {
            return MaxCapacity - CurrentWeightLoad;
        }
        public double getRemainingSize()
        {
            return VehicleSize - CurrentSizeLoad;
        }
    }
    //Derived Classes:
    
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
        public Drone() { this.MaxCapacity = 5; } //For unit tests Should be ensured that i have it capped at 5kg.;
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

    public sealed class ElectricBike : ElectricVehicle 
    {
    }

    //Creating HeavydutyHydrogenTruck class (Sealed)
    public sealed class HeavydutyHydrogenTruck : HydrogenVehicle 
    {
        //For the unit tests I'll have this capped at 5000kg.
        public HeavydutyHydrogenTruck() { this.MaxCapacity = 5000; }
    }
}
