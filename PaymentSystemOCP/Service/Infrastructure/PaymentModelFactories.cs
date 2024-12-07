using System;
using System.Collections.Generic;
using System.Linq;
using PaymentSystemOCP.Factories;

namespace PaymentSystemOCP
{
    public class PaymentModelFactories
    {
        private readonly Dictionary<string, IPaymentModelFactory> _factories;

        public PaymentModelFactories() =>
            _factories = Create();

        public IReadOnlyList<IPaymentModelFactory> GetAll() =>
            _factories.Values.ToList();

        public IPaymentModelFactory Get(string modelId)
        {
            if (string.IsNullOrEmpty(modelId))
                throw new ArgumentNullException(nameof(modelId));

            return _factories[modelId];
        }

        private Dictionary<string, IPaymentModelFactory> Create()
        {
            return new Dictionary<string, IPaymentModelFactory>
            {
                ["qiwi"] = new QiwiPaymentModelFactory(),
                ["webmoney"] = new WebMoneyPaymentModelFactory(),
                ["card"] = new CardPaymentModelFactory()
            };
        }
    }
}
