
namespace Ryder.Application.Payment.Query
{
    public class VerifyPaymentResponse
    {
        public bool IsPaymentValid { get; set; }
        public string Message { get; set; }
        public Guid OrderId { get; set; }
    }
}
