using OPT.Business.Enums;
using OPT.Business.Handlers;
using OPT.Business.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPT.Business
{
    public static class PaymentBuilder 
    {
        /// <summary>
        /// Factory method to generate the object based on the category.
        /// </summary>
        /// <param name="orderPaymentBase"></param>
        /// <returns></returns>
        public static IPayment PaymentFactory(IOrderPaymentBase orderPaymentBase)
        {
            switch (orderPaymentBase.paymentCategory)
            {
                case PaymentCategory.PhysicalProduct:
                    return new PhysicalProductPayment();

                default:
                    throw new NotImplementedException("Order Payment is not implemented of the type " + nameof(orderPaymentBase));
            }
        }

    }
}
