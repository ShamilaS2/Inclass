using System;

namespace VehicleFactoryDemo
{
    public class GasolineCar : IVehicle
    {
        public void ShowDetails()
        {
            Console.WriteLine("Vehicle: Gasoline Car - a fuel-powered passenger car.");
        }
    }
}
