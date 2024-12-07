namespace PaymentSystemOCP
{
    public class WebMoneyPaymentStrategy : IPaymentSrategy
    {
        public string GetPaymentResult() =>
            "Вызов API WebMoney...";
    }
}
