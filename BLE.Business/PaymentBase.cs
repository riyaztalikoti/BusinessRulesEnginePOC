namespace OPT.Business
{
    public abstract class PaymentBase : IPayment
    {
        public int PaymentId { get; set; }

        public void ProcessPayment()
        {

        }

    }
}
