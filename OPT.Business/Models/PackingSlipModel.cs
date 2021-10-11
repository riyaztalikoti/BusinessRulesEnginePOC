using OPT.Business.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPT.Business.Models
{
    public class PackingSlipModel : IPostPaymentProcess
    {
        public int PackingSlipId { get; set; }

        public Address Address { get; set; }

        public string Description { get; set; }
    }
}
