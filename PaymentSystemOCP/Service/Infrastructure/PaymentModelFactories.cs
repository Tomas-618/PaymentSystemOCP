using System;
using System.Collections.Generic;
using System.Linq;
using PaymentSystemOCP.Factories;

namespace PaymentSystemOCP
{
    public class PaymentModelFactories : IPaymentModelFactoriesKeys
    {
        private readonly Dictionary<string, IPaymentModelFactory> _factories;

        public PaymentModelFactories() =>
            _factories = Create();

        public IReadOnlyList<string> GetAllKeys() =>
            _factories.Keys.ToList();

        public IPaymentModelFactory Get(string modelId)
        {
            if (string.IsNullOrEmpty(modelId))
                throw new ArgumentNullException(nameof(modelId));

            return _factories[modelId];
        }

        private Dictionary<string, IPaymentModelFactory> Create()
        {
            return new Dictionary<string, IPaymentModelFactory>(StringComparer.InvariantCultureIgnoreCase)
            {
                ["QIWI"] = new QiwiPaymentModelFactory(),
                ["WebMoney"] = new WebMoneyPaymentModelFactory(),
                ["Card"] = new CardPaymentModelFactory()
            };
        }
    }
}
