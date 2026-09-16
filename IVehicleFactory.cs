namespace VehicleFactoryDemo
{

    public interface IVehicleFactory
    {
        IVehicle CreateCar();
        IVehicle CreateTruck();
        IEngine CreateEngine();
    }
}
