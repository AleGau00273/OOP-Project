using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Project_Jonathan_Alex_Abdin
{
    //Interface Defined for IDeliverable (Package)

    //IDeliverable acts as a "Contract".
    //Any class that implements this MUST have a weight and PackageSize.
    //This allows the Vehicle Class to interact with anything "Deliverable"
    //without needing to know the specifics of what is being delivered.
    public interface IDeliverable
    {
        //Requirement for Weight and size properties in any class that implements this interface.
        double Weight { get; set; }
        double PackageSize { get; set; }
    }


    //Class Implementation

    //The Package class implements the IDeliverable interface.
    //This fulfills the requirment of creating a concrete item,
    //That can be loaded onto vehicles
    public class Package : IDeliverable
    {

        //Properties used for UI Display and tracking purposes.
        public string PackageID { get; set; }
        public string Description { get; set; }

        //Interface Properties
        //These are required by IDeliverable.
        //The weight property is used by the '+' operator overload to check against a vehicle's maxCapacity.
        public double Weight { get; set; }
        public double PackageSize { get; set; }
       

        //returns the current weight of the package.
        public double GetWeight()
        {
            return Weight;
        }

        //Returns the Physical dimensions of the package.
        public double GetSize()
        {
            return PackageSize;
        }
    }
}
