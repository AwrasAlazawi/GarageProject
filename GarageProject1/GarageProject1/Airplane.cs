using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageProject1
{
    class Airplane: Vehicle
    {
        public Airplane(int regNo, string color, int noOfWheels, int noOfSeats):base(regNo,color,noOfWheels)
        {
            NoOfSeats = noOfSeats;
        }
        public int NoOfSeats { get; set; }
    }
}
