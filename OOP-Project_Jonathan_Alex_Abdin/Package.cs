using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Project_Jonathan_Alex_Abdin
{
    // Creating Package class
    // Features: [F-05] (Encapsulation and Data Validation)
    public class Package
    {
        // Properties and lists
        // [F-05] Private backing fields
        private double _weight;
        private double _packageSize;

        public string PackageID { get; set; }
        public string Description { get; set; }

        // [F-05] Public Properties with validation logic
        public double Weight
        {
            get => _weight;
            set => _weight = (value < 0) ? 0 : value;
        }

        public double PackageSize
        {
            get => _packageSize;
            set => _packageSize = (value < 0) ? 0 : value;
        }

        // Methods

        public Package(string id, string desc, double weight, double size)
        {
            PackageID = id;
            Description = desc;
            Weight = weight;
            PackageSize = size;
        }

        public double GetWeight() => Weight;
        public double GetSize() => PackageSize;
    }
}