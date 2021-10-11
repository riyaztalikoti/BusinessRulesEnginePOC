using OPT.Business.Interface;
using OPT.Business.Models;
using System;

namespace OPT.Business.Handlers
{
    public class PhysicalProductPayment : IPayment
    {
        public PhysicalProductPayment()
        {
            // Todo:  Check if any DI container is required to configure for injection.
        }

        public IPostPaymentProcess ProcessPayment()
        {
            PackingSlipModel packingSlipModel = null;
            try
            {               
                packingSlipModel = new PackingSlipModel()
                {
                    PackingSlipId = 1,
                    Description = "Mock data from business layer",
                    Address = new Address()
                    {
                        AddressId=1,
                        City="Bangalore",
                        ZIP="560076",
                        Country="India",
                        Street="ST Road"
                    }
                };
            }
            catch (Exception ex)
            {
                // Todo:  Serilog consume ex structured way.
                throw;
            }
            // return PackingSlipModel
            return packingSlipModel;
        }
    }
}