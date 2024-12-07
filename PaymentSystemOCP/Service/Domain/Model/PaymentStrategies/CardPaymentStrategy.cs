namespace PaymentSystemOCP
{
    public class CardPaymentStrategy : IPaymentSrategy
    {
        public string GetPaymentResult() =>
            "Вызов API банка эмитера карты Card...";
    }
}
