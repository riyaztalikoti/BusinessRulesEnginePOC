using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPT.Business
{
    public class PaymentBuilder
    {
        private IPayment PaymentFactory(IOrderPaymentBase orderPaymentBase)
        {
            switch (orderPaymentBase)
            {
                default:
                    throw new NotImplementedException("Order Payment is not implemented of the type " + nameof(orderPaymentBase));
            }
        }
    }
}
