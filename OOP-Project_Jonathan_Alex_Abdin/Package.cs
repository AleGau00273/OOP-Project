using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Project_Jonathan_Alex_Abdin
{
    public class Package
    {
        public string PackageID { get; set; }
        public double Weight { get; set; }
        public double PackageSize { get; set; }
        public string Description { get; set; }

        public double GetWeight()
        {
            return Weight;
        }

        public double GetSize()
        {
            return PackageSize;
        }
    }
}
