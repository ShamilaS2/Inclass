using System;

namespace VehicleFactoryDemo
{
    public class GasolineTruck : IVehicle
    {
        public void ShowDetails()
        {
            Console.WriteLine("Vehicle: Gasoline Truck - a fuel-powered heavy-duty truck.");
        }
    }
}
