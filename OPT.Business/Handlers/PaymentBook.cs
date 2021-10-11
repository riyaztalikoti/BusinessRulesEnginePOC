using OPT.Business.Interface;
using OPT.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPT.Business.Handlers
{
    public class PaymentBook : IPayment
    {
        public IPostPaymentProcess ProcessPayment()
        {
            IPostPaymentProcess postPaymentProcess = null;

            try
            {
                postPaymentProcess = new PackingSlipModel()
                {
                    PackingSlipId = 1,
                    Description = "Mock data from business layer",
                    Address = new Address()
                    {
                        AddressId = 1,
                        City = "Bangalore",
                        ZIP = "560076",
                        Country = "India",
                        Street = "ST Road"
                    },
                    Department = new Department()
                    {
                        DepartmentId = 1,
                        DepartmentName = "Royalty"
                    }

                };
            }
            catch (Exception)
            {
                // use Serilog/DB
                throw;
            }

            return postPaymentProcess;
        }
    }
}
