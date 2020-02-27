using System;
using System.Collections.Generic;
using System.Text;

namespace DepartmentOfTransport
{
    partial class RoadVehicle
    {
        // Variables
        public static string projectVersion = "1.0";

        public int EngineSerialNumber { get; }
        public int NumberOfWheels { get; }
        public int CarriageCapacity { get; }

        private string description;
        public virtual string Description
        {
            get
            {
                if (description == null)
                {
                    description = string.Format("Road Vehicle. Wheels: {0:d}, Capacity: {1:d} people, serialNo: {2:d}", NumberOfWheels, CarriageCapacity, EngineSerialNumber);
                }
                return description;
            }
        }
    }
}
