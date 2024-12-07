namespace PaymentSystemOCP.Factories
{
    public class WebMoneyPaymentModelFactory : IPaymentModelFactory
    {
        public IPaymentModel Create() =>
            new WebMoneyPaymentModel();
    }
}
