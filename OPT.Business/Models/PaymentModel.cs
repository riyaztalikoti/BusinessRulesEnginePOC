using OPT.Business.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPT.Business.Models
{
    /// <summary>
    /// Payment model
    /// </summary>
    public class PaymentModel : IOrderPaymentBase
    {
        public PaymentModel()
        {
        }

        public int PaymentId { get; set; }

        public PaymentCategory paymentCategory { get; set; }

        public string PaymentNotes { get; set; }
    }
}
