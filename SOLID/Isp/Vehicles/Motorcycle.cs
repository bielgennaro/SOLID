#region

using System;

#endregion

namespace Isp.Vehicles
{
    public class Motorcycle : IVehicleMotorcycle
    {
        private string color;
        private double engine;
        private int year;

        public Motorcycle(string color, int year, double engine)
        {
            ConfigureMotorcycle(color, year, engine);
        }

        public void ConfigureMotorcycle(string color, int year, double engine)
        {
            this.color = color;
            this.year = year;
            this.engine = engine;

            Console.WriteLine($"Criando uma moto de cor {color}, ano {year} e {engine} cilindradas");
            StartEngine();
        }

        public void StartEngine()
        {
            Console.WriteLine("Ligando o motor!");
        }
    }
}