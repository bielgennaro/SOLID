#region

using Isp.Vehicles;

#endregion

namespace Isp
{
    internal class Program
    {
        /// <summary>
        ///     Interface segregation principle:
        ///     A client should never be forced to implement an interface that it doesn’t use, or clients shouldn’t be forced to
        ///     depend on methods they do not use.
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
            var car = new Car("Azul", 2020, 4.0, 5, 2);

            var motorcycle = new Motorcycle("Branca", 2023, 1000);
        }
    }
}