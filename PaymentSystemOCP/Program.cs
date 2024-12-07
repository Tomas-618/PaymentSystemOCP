using PaymentSystemOCP.Factories;

namespace PaymentSystemOCP
{
    internal class Program
    {
        private static void Main()
        {
            OrderForm orderForm = new OrderForm();

            PaymentHandler paymentHandler = new PaymentHandler();

            PaymentModels paymentStrategies = new PaymentModels();

            string systemId = orderForm.ShowForm();

            IPaymentModelFactory paymentModelFactory = paymentStrategies.GetPaymentModel(systemId);

            paymentHandler.ShowPaymentResult(paymentModelFactory);
        }
    }
}
