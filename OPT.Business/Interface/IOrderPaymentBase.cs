using OPT.Business.Enums;
using OPT.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPT.Business
{
    public interface IOrderPaymentBase
    {
        public PaymentCategory paymentCategory { get; set; }

    }
}
