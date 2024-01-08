using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ocp.Models
{
    class Car : Vehicle
    {
        private int Doors;
        private int Seats;

        public Car(string color, double engine, int year, int doors, int seats): base(color, engine, year)
        {
            this.Seats = seats;
            this.Doors = doors;

            ConfigureCar();
        }

        public void ConfigureCar()
        {
            Console.WriteLine($"Criando um carro {Color}, {Engine}, {Year}, {Doors} portas e {Seats} assentos!");
            StartEngine();
        }
    }
}
