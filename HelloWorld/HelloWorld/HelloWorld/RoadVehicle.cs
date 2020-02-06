using System;
using System.Collections.Generic;
using System.Text;

namespace DepartmentOfTransport
{
    class RoadVehicle
    {
        // Variables
        public static string projectVersion = "1.0";

        public int EngineSerialNumber { get; }
        public int NumberOfWheels { get; }
        public int CarriageCapacity { get; }

        public string Description => string.Format("Road Vehicle. Wheels: {0:d}, Capacity: {1:d} people", NumberOfWheels, CarriageCapacity);

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
