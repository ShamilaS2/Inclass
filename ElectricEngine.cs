using System;

namespace VehicleFactoryDemo
{
    public class ElectricEngine : IEngine
    {
        public void Start()
        {
            Console.WriteLine("Electric engine starting: battery engaged, motor spinning up silently...");
        }
    }
}
