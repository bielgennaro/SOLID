#region

using System;

#endregion

namespace Lsp.Payments
{
    internal abstract class MercadoPagoCard : IPaymentInstrument
    {
        public void CollectPayment()
        {
            Console.WriteLine("Recebendo pagamento!");
        }

        public virtual void Validate()
        {
            Console.WriteLine("Validando saldo!");
        }
    }
}