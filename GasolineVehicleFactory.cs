namespace VehicleFactoryDemo
{

    public class GasolineVehicleFactory : IVehicleFactory
    {
        public IVehicle CreateCar() => new GasolineCar();

        public IVehicle CreateTruck() => new GasolineTruck();

        public IEngine CreateEngine() => new GasolineEngine();
    }
}
