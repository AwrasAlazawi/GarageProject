using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageProject1
{
    class Vehicle
    {

        public Vehicle(int regNo, string color, int noOfWheels)
        {
            RegNo = regNo;
            Color = color;
            NoOfWheels = noOfWheels;
        }
        public int RegNo { get; set; }
        public int NoOfWheels { get; set; }
        public string Color { get; set; }

    }
}
