using System;
using PaymentSystemOCP.Factories;

namespace PaymentSystemOCP
{
    public class PaymentHandler
    {
        public void ShowPaymentResult(IPaymentModelFactory paymentModelFactory)
        {
            if (paymentModelFactory == null)
                throw new ArgumentNullException(nameof(paymentModelFactory));

            IPaymentModel paymentModel = paymentModelFactory.Create();

            string paymentResult = paymentModel.GetPaymentResult();

            Console.WriteLine(paymentResult);
            Console.WriteLine($"Вы оплатили с помощью {paymentModel}");

            Console.WriteLine($"Проверка платежа через {paymentModel}...");
            Console.WriteLine("Оплата прошла успешно!");
        }
    }
}
