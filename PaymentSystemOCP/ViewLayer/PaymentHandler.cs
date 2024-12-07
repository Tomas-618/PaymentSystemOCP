using System;

namespace PaymentSystemOCP
{
    public class PaymentHandler
    {
        public void ShowPaymentResult(string systemId)
        {
            Console.WriteLine($"Вы оплатили с помощью {systemId}");

            Console.WriteLine($"Проверка платежа через {systemId}...");
            Console.WriteLine("Оплата прошла успешно!");
        }
    }
}
