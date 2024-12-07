namespace PaymentSystemOCP
{
    public class WebMoneyPaymentModel : IPaymentModel
    {
        public string GetPaymentResult() =>
            $"Вызов API {ToString()}...";

        public override string ToString() =>
            "WebMoney";
    }
}
