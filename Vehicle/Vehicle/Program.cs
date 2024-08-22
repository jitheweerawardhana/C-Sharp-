using Vehicle;

class Program
{
    static void Main(string[] args)
    {
        IVehicleFactory gasolineFactory = new GasolineVehicleFactory();

        IVehicle gasolineCar = gasolineFactory.CreateCar();
        IEngine gasolineEngine = gasolineFactory.CreateEngine();

        gasolineCar.ShowDetails();
        gasolineEngine.Start();

        IVehicleFactory electricFactory = new ElectricVehicleFactory();

        IVehicle electricTruck = electricFactory.CreateTruck();
        IEngine electricEngine = electricFactory.CreateEngine();

        electricTruck.ShowDetails();
        electricEngine.Start();
    }
}