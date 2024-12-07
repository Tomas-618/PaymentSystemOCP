namespace PaymentSystemOCP
{
    public class CardPaymentModel : IPaymentModel
    {
        public string GetPaymentResult() =>
            $"Вызов API банка эмитера карты {ToString()}...";

        public override string ToString() =>
            "Card";
    }
}
