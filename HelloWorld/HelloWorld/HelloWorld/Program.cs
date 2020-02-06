using System;
using DepartmentOfTransport;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Code running: Project Version " + RoadVehicle.projectVersion);

            RoadVehicle v1 = new RoadVehicle(123456);
            RoadVehicle v2 = new RoadVehicle(246810, 3, 1);

            if ((v1 is null) || (v2 is null))
            {
                Console.WriteLine("Error: object is null.");
                return;
            }

            Console.WriteLine(v1.GetDescription);
            Console.WriteLine(v2.GetDescription);

            Console.ReadLine();
        }
    }
}
