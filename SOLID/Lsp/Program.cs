#region

using Lsp.Payments;

#endregion

namespace Lsp
{
    internal class Program
    {
        /// <summary>
        ///     Liskov Substitution Principle:
        ///     Every subclass or derived class should be substitutable for their base or parent class.
        /// </summary>
        /// <param name="args"></param>
        private static void Main(string[] args)
        {
            var card = new MercadoPagoRewards();

            card.Validate();
            card.CollectPayment();
        }
    }
}