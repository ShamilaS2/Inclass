using System;

namespace VehicleFactoryDemo
{
    public class ElectricCar : IVehicle
    {
        public void ShowDetails()
        {
            Console.WriteLine("Vehicle: Electric Car - a battery-powered passenger car.");
        }
    }
}
