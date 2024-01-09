#region

using System;

#endregion

namespace Lsp.Payments
{
    internal class DebitCard : MercadoPagoCard
    {
        public override void Validate()
        {
            Console.WriteLine("Validando saldo...");
            Console.WriteLine("Saldo ok!");
        }
    }
}