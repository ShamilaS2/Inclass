using System;

namespace VehicleFactoryDemo
{
    public class ElectricTruck : IVehicle
    {
        public void ShowDetails()
        {
            Console.WriteLine("Vehicle: Electric Truck - a battery-powered heavy-duty truck.");
        }
    }
}
