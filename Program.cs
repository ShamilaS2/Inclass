using System;
using VehicleFactoryDemo;

namespace VehicleFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter engine type (GASOLINE / ELECTRIC): ");
            string choice = Console.ReadLine().ToUpper();

            IVehicleFactory factory;

            if (choice == "GASOLINE")
            {
                factory = new GasolineVehicleFactory();
            }
            else
            {
                factory = new ElectricVehicleFactory();
            }

            IVehicle car = factory.CreateCar();
            IEngine engine = factory.CreateEngine();

            car.ShowDetails();
            engine.Start();
        }
    }
}