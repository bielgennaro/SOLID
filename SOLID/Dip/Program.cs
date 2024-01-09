using Dip.Payment;

namespace Dip
{
    internal class Program
    {
        /// <summary>
        ///     Dependency inversion principle:
        ///     Entities must depend on abstractions, not on concretions. It states that the high-level module must not depend on
        ///     the low-level module, but they should depend on abstractions.
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
            var payment = new PaymentProcess();
            
            payment.Pay("Abc 1223");
            
        }
    }
}