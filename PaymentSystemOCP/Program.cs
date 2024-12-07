using PaymentSystemOCP.Factories;

namespace PaymentSystemOCP
{
    internal class Program
    {
        private static void Main()
        {
            PaymentModelFactories paymentModelFactories = new PaymentModelFactories();

            OrderForm orderForm = new OrderForm(paymentModelFactories);

            PaymentHandler paymentHandler = new PaymentHandler();

            string modelId = orderForm.ShowForm();

            IPaymentModelFactory paymentModelFactory = paymentModelFactories.Get(modelId);

            paymentHandler.ShowPaymentResult(paymentModelFactory);
        }
    }
}
