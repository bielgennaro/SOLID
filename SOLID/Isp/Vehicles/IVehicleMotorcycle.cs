namespace Isp.Vehicles
{
    public interface IVehicleMotorcycle : IVehicle
    {
        void ConfigureMotorcycle(string color, int year, double engine);
    }
}