using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Code running: Project Version " + RoadVehicle.projectVersion);

            RoadVehicle v1 = new RoadVehicle(123456);
            RoadVehicle v2 = new RoadVehicle(246810);

            if (!(v1 is null) && !(v2 is null))
            {
                Console.WriteLine("Vehicle 1 serial: " + v1.GetEngineSerialNumber() + " Vehicle 2 serial: " + v2.GetEngineSerialNumber());
            }
            else 
            {
                System.Console.WriteLine("Error: object is null.");
                return;
            }

            Console.ReadLine();
        }
    }
}
