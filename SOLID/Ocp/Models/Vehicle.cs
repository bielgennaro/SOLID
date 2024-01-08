using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ocp.Models
{
    class Vehicle
    {
        protected string Color;
        protected double Engine;
        protected int Year;

        public Vehicle(string color, double engine, int year) 
        {
            Color = color;
            Engine = engine;
            Year = year;
        }

        public void StartEngine()
        {
            Console.WriteLine("Ligando o motor! Vruuum");
        }
    }
}
