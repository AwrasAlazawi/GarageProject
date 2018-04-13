using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageProject1
{
    class Bus:Vehicle
    {
        public Bus(int regNo, string color, int noOfWheels, string fueltype) : base(regNo, color, noOfWheels)
        {
            FuelType = fueltype;
        }
        public string FuelType { get; set; }
    }
}
