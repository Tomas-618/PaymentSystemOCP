namespace PaymentSystemOCP
{
    public class QiwiPaymentModel : IPaymentModel
    {
        public string GetPaymentResult() =>
            $"Перевод на страницу {ToString()}...";

        public override string ToString() =>
            "QIWI";
    }
}
