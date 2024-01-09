using System;
using Dip.Factory;
using Dip.Model;

namespace Dip.Payment
{
    public class PaymentProcess
    {
        public void Pay(string id)
        {
            var product = DbProductFactory.Create();
            var productData = product.GetProductById(id);

            Console.WriteLine(productData);
        }
    }
}