using System;
using System.Collections.Generic;
using PaymentSystemOCP.Factories;

namespace PaymentSystemOCP
{
    public class OrderForm
    {
        private readonly PaymentModelFactories _paymentModelFactories;

        public OrderForm(PaymentModelFactories paymentModelFactories) =>
            _paymentModelFactories = paymentModelFactories ??
            throw new ArgumentNullException(nameof(paymentModelFactories));

        public string ShowForm()
        {
            IReadOnlyList<IPaymentModelFactory> factories = _paymentModelFactories.GetAll();

            if (factories.Count == 0)
            {
                Console.WriteLine("На данный момент нет доступных систем оплаты");

                return string.Empty;
            }

            ShowAllPaymentModels(factories);
            
            Console.WriteLine("Какой системой вы хотите совершить оплату?");

            return Console.ReadLine().ToLower().Trim();
        }

        private void ShowAllPaymentModels(IReadOnlyList<IPaymentModelFactory> factories)
        {
            string paymentModels = "Мы принимаем: ";

            foreach (IPaymentModelFactory factory in factories)
                paymentModels += $"{factory.Create().ToString()}, ";

            paymentModels = paymentModels.TrimEnd(',', ' ');

            Console.WriteLine(paymentModels);
        }
    }
}
