
namespace Ryder.Application.Payment.Command
{
    public class PaymentResponse
    {
        public bool Status { get; set; }
        public string AuthUrl { get; set; }
        public string Message { get; set; }
        public Guid OrderId { get; set; }
    }
}
