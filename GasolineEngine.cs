using System;

namespace VehicleFactoryDemo
{
    public class GasolineEngine : IEngine
    {
        public void Start()
        {
            Console.WriteLine("Gasoline engine starting: turning ignition key, fuel injection active...");
        }
    }
}
