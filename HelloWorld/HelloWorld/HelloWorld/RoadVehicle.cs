using System;
using System.Collections.Generic;
using System.Text;

namespace DepartmentOfTransport
{
    class RoadVehicle
    {
        // Variables
        public static string projectVersion = "1.0";

        private int _engineSerialNumber;
        private int _numberOfWheels;
        private int _carriageCapacity;

        // Constructors
        public RoadVehicle(int engineSerialNumber, int numberOfWheels=4, int carriageCapacity=5)
        {
            _engineSerialNumber = engineSerialNumber;
            _numberOfWheels = numberOfWheels;
            _carriageCapacity = carriageCapacity;

            Console.WriteLine("New vehicle successfully constructed.");
        }

        // Getters
        public int EngineSerialNumber => _engineSerialNumber;

        public int GetNumberOfWheels => _numberOfWheels;

        public int GetCarriageCapacity => _carriageCapacity;

        public string GetDescription
        {
            get { return string.Format("Road Vehicle. Wheels: {0:d}, Capacity: {1:d} people, serialNo: {2:d}", _numberOfWheels, _carriageCapacity, _engineSerialNumber); }
        }
    }
}
