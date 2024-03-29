﻿#region

using Ocp.Enums;
using Ocp.Models;

#endregion

namespace Ocp
{
    internal class Program
    {
        /// <summary>
        ///     Open Closed Principle:
        ///     Objects or entities should be open for extension but closed for modification.
        /// </summary>
        /// <param name="args"></param>
        private static void Main(string[] args)
        {
            var type = TypeOfVehicle.Motorcycle;

            if (type == TypeOfVehicle.Car)
            {
                var vehicle = new Car("preto", 2.0, 2000, 2, 2);
            }
            else
            {
                var vehicle = new Motorcycle("branca", 1000, 1990);
            }
        }
    }
}