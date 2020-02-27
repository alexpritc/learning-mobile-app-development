using System;
using System.Collections.Generic;
using System.Text;

namespace DepartmentOfTransport
{
    partial class RoadVehicle
    {
        // Constructors
        public RoadVehicle(int engineSerialNumber, int numberOfWheels=4, int carriageCapacity=5)
        {
            EngineSerialNumber = engineSerialNumber;
            NumberOfWheels = numberOfWheels;
            CarriageCapacity = carriageCapacity;

            Console.WriteLine("New vehicle successfully constructed.");
        }
    }
}
