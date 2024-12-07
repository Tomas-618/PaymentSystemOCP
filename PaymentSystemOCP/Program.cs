using System;

namespace PaymentSystemOCP
{
    internal class Program
    {
        private static void Main()
        {
            OrderForm orderForm = new OrderForm();

            PaymentHandler paymentHandler = new PaymentHandler();

            PaymentStrategies paymentStrategies = new PaymentStrategies();

            string systemId = orderForm.ShowForm();

            try
            {
                string result = paymentStrategies.GetPaymentResult(systemId);

                Console.WriteLine(result);
                paymentHandler.ShowPaymentResult(systemId);
            }
            catch (PaymentStrategyIdNotFoundException exception)
            {
                Console.WriteLine($"Не удалось найти систему оплаты по ключу <<{exception.Id}>>");
            }
        }
    }
}
