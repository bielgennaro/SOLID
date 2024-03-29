﻿#region

using System;

#endregion

namespace Ocp.Models
{
    internal class Motorcycle : Vehicle
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