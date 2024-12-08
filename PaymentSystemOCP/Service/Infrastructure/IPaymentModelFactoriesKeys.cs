using System.Collections.Generic;

namespace PaymentSystemOCP
{
    public interface IPaymentModelFactoriesKeys
    {
        IReadOnlyList<string> GetAllKeys();
    }
}
