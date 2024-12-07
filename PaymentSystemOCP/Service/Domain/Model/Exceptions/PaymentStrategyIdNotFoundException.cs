using System;

namespace PaymentSystemOCP
{
    public class PaymentStrategyIdNotFoundException : Exception
    {
        public PaymentStrategyIdNotFoundException(string id) =>
            Id = id ?? string.Empty;

        public string Id { get; }
    }
}
