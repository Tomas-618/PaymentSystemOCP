namespace PaymentSystemOCP.Factories
{
    public class CardPaymentModelFactory : IPaymentModelFactory
    {
        public IPaymentModel Create() =>
            new CardPaymentModel();
    }
}
