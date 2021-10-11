using OPT.Business.Interface;

namespace OPT.Business
{
    public abstract class PaymentBase : IPayment
    {
        public int PaymentId { get; set; }

        public virtual IPostPaymentProcess ProcessPayment()
        {
            throw new System.NotImplementedException();
        }
    }
}
