namespace PaymentSystemOCP.Factories
{
    public class QiwiPaymentModelFactory : IPaymentModelFactory
    {
        public IPaymentModel Create() =>
            new QiwiPaymentModel();
    }
}
