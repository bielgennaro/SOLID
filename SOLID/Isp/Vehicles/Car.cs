#region

using System;

#endregion

namespace Isp.Vehicles
{
    public class Car : IVehicleCar
    {
        private string color;
        private int doors;
        private double engine;
        private int seats;
        private int year;

        public Car(string color, int year, double engine, int seats, int doors)
        {
            ConfigureCar(color, year, engine, seats, doors);
        }

        public void ConfigureCar(string color, int year, double engine, int seats, int doors)
        {
            this.color = color;
            this.year = year;
            this.engine = engine;
            this.seats = seats;
            this.doors = doors;

            Console.WriteLine(
                $"Criando carro da cor {color}, com um motor {engine}, ano {year}, {seats} bancos e {doors} portas");
            StartEngine();
        }

        public void StartEngine()
        {
            Console.WriteLine("Ligando o motor!");
        }
    }
}