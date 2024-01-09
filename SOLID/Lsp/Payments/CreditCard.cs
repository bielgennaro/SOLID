#region

using System;

#endregion

namespace Lsp.Payments
{
    internal class CreditCard : MercadoPagoCard
    {
        public override void Validate()
        {
            Console.WriteLine("Validando limite...");
            Console.WriteLine("Limite ok!");
        }
    }
}