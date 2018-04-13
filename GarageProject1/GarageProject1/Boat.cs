using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageProject1
{
    class Boat:Vehicle
    {

        public Boat(int regNo, string color, int noOfWheels, float length) : base(regNo, color, noOfWheels)
        {
            Length = length;
        }
        public float Length { get; set; }
    }
}
