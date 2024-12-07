namespace PaymentSystemOCP
{
    public class QiwiPaymentStrategy : IPaymentSrategy
    {
        public string GetPaymentResult() =>
            "Перевод на страницу QIWI...";
    }
}
