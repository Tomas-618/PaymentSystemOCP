using System.Collections.Generic;

namespace PaymentSystemOCP
{
    public class PaymentStrategies
    {
        private readonly Dictionary<string, IPaymentSrategy> _strategies;

        public PaymentStrategies() =>
            _strategies = Create();

        public string GetPaymentResult(string systemId)
        {
            try
            {
                return _strategies[systemId].GetPaymentResult();
            }
            catch (KeyNotFoundException)
            {
                throw new PaymentStrategyIdNotFoundException(systemId);
            }
        }

        private Dictionary<string, IPaymentSrategy> Create()
        {
            return new Dictionary<string, IPaymentSrategy>
            {
                ["qiwi"] = new QiwiPaymentStrategy(),
                ["webmoney"] = new WebMoneyPaymentStrategy(),
                ["card"] = new CardPaymentStrategy()
            };
        }
    }
}
