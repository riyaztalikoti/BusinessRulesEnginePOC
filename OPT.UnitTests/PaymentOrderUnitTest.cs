using Microsoft.VisualStudio.TestTools.UnitTesting;
using OPT.Business;
using OPT.Business.Enums;
using OPT.Business.Handlers;
using OPT.Business.Interface;
using OPT.Business.Models;
using System;

namespace OPT.UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void HelloTest()
        {
            // Prepare
            var payamentModel = new PaymentModel()
            {
                paymentCategory = PaymentCategory.PhysicalProduct,
                PaymentId = 1,
                PaymentNotes = "Perfoming unit test on PhysicalProduct payment"
            };

            // Act
            var processPayment = PaymentBuilder.PaymentFactory(payamentModel);


            // Assert
            Assert.IsNotNull(processPayment);
        }

    }
}
