#region

using System;

#endregion

namespace Ocp.Models
{
    internal class Vehicle : IVehicle
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