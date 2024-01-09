#region

using System;

#endregion

namespace Ocp.Models
{
    internal class Car : Vehicle
    {
        private readonly int Doors;
        private readonly int Seats;

        public Car(string color, double engine, int year, int doors, int seats) : base(color, engine, year)
        {
            Seats = seats;
            Doors = doors;

            ConfigureCar();
        }

        public void ConfigureCar()
        {
            Console.WriteLine($"Criando um carro {Color}, {Engine}, {Year}, {Doors} portas e {Seats} assentos!");
            StartEngine();
        }
    }
}