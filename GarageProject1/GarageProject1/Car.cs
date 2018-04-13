using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarageProject1
{
    class Car :Vehicle
    {
        public Car(int regNo, string color, int noOfWheels, int noOfEngines) : base(regNo, color, noOfWheels)
        {
            Numberofengines = noOfEngines;
        }
        public int Numberofengines { get; set; }
    }
}
