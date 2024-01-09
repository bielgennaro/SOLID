#region

using System;

#endregion

namespace Lsp.Payments
{
    internal class MercadoPagoRewards : IPaymentInstrument
    {
        public void CollectPayment()
        {
            Console.WriteLine("Pagamento realizado com sucesso!");
            Console.WriteLine("Pontuação creditada");
        }

        public void Validate()
        {
            Console.WriteLine("Limite Ok, Rewards Ok");
        }
    }
}