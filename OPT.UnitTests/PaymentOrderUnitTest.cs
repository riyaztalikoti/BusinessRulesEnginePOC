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

        /// <summary>
        /// Physical Product payment test
        /// </summary>
        [TestMethod]
        public void PhysicalProduct_Payment_Process_Should_Return_PackingSlip_Model_Test()
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

            var packingSlipModel = processPayment.ProcessPayment();

            // Assert
            Assert.IsNotNull(packingSlipModel);
            Assert.IsInstanceOfType(packingSlipModel, typeof(PackingSlipModel));
        }


        /// <summary>
        /// Book payment test
        /// </summary>
        [TestMethod]
        public void BookProduct_Payment_Process_Should_Return_PackingSlip_Model_Test()
        {
            // Prepare
            var payamentModel = new PaymentModel()
            {
                paymentCategory = PaymentCategory.Book,
                PaymentId = 1,
                PaymentNotes = "Perfoming unit test on book payment"
            };

            // Act
            var processPayment = PaymentBuilder.PaymentFactory(payamentModel);

            var packingSlipModel = processPayment.ProcessPayment();

            var castModel = (PackingSlipModel)packingSlipModel;

            // Assert
            Assert.IsNotNull(packingSlipModel);
            Assert.IsInstanceOfType(packingSlipModel, typeof(PackingSlipModel));
            Assert.AreEqual(castModel.Department.DepartmentName, "Royalty");
        }
    }
}
