using System;
using System.Collections.Generic;

namespace PaymentSystemOCP
{
    public class OrderForm
    {
        private readonly IPaymentModelFactoriesKeys _paymentModelFactories;

        public OrderForm(IPaymentModelFactoriesKeys paymentModelFactories) =>
            _paymentModelFactories = paymentModelFactories ??
            throw new ArgumentNullException(nameof(paymentModelFactories));

        public string ShowForm()
        {
            IReadOnlyList<string> factoriesKeys = _paymentModelFactories.GetAllKeys();

            if (factoriesKeys.Count == 0)
            {
                Console.WriteLine("На данный момент нет доступных систем оплаты");

                return string.Empty;
            }

            ShowAllPaymentModels(factoriesKeys);
            
            Console.WriteLine("Какой системой вы хотите совершить оплату?");

            return Console.ReadLine().Trim();
        }

        private void ShowAllPaymentModels(IReadOnlyList<string> factoriesKeys)
        {
            string paymentModels = "Мы принимаем: ";

            foreach (string factory in factoriesKeys)
                paymentModels += $"{factory}, ";

            paymentModels = paymentModels.TrimEnd(',', ' ');

            Console.WriteLine(paymentModels);
        }
    }
}
