namespace VehicleFactoryDemo
{

    public class ElectricVehicleFactory : IVehicleFactory
    {
        public IVehicle CreateCar() => new ElectricCar();

        public IVehicle CreateTruck() => new ElectricTruck();

        public IEngine CreateEngine() => new ElectricEngine();
    }
}
