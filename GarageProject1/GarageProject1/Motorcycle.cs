using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageProject1
{
    class Motorcycle : Vehicle
    {
        public Motorcycle(int regNo, string color, int noOfWheels, int cylinderV) : base(regNo, color, noOfWheels)
        {
            CylinderVolume = cylinderV;
        }
        public int CylinderVolume { get; set; }
    }
}
