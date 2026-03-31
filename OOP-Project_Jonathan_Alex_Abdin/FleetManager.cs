using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Project_Jonathan_Alex_Abdin
{
    public class FleetManager
    {
        // Properties and lists
        private List<Vehicle> Vehicles = new List<Vehicle>();

        //Methods
        public void AddVehicle(Vehicle vec) 
        {
            Vehicles.Add(vec);
        }
        public void RemoveVehicle(Vehicle vec) 
        {
            Vehicles.Remove(vec);
        }
    }
}
