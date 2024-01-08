using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ocp.Models
{
    class Motorcycle : Vehicle
    {

        public Motorcycle(string color, int engine, int year) : base(color, engine, year)
        {
            ConfigureMotorcycle();
        }

        public void ConfigureMotorcycle()
        {
            Console.WriteLine($"Criando uma moto {Color}, {Year} e {Engine} cilindradas!");
            StartEngine();
        }
    }
}
