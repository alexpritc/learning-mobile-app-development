using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    class RoadVehicle
    {
        public static string projectVersion = "1.0";
        private int engineSerialNumber;

        public RoadVehicle() 
        {  
            Console.WriteLine("RoadVehicle constructor.");
        }

        public RoadVehicle(int engineSerialNumber)
        {
            this.engineSerialNumber = engineSerialNumber;
        }

        public int GetEngineSerialNumber()
        {
            return this.engineSerialNumber;
        }
    }
}
