using OPT.Business.Interface;

namespace OPT.Business
{
    /// <summary>
    /// IPayment base interface 
    /// </summary>
    public interface IPayment
    {
        IPostPaymentProcess ProcessPayment();
    }
}