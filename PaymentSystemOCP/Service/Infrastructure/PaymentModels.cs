using System;
using System.Collections.Generic;
using PaymentSystemOCP.Factories;

namespace PaymentSystemOCP
{
    public class PaymentModels
    {
        private readonly Dictionary<string, IPaymentModelFactory> _strategies;

        public PaymentModels() =>
            _strategies = Create();

        public IPaymentModelFactory GetPaymentModel(string systemId)
        {
            if (string.IsNullOrEmpty(systemId))
                throw new ArgumentNullException(nameof(systemId));

            return _strategies[systemId];
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
