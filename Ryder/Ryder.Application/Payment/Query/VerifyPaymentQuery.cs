using AspNetCoreHero.Results;
using FluentValidation;
using MediatR;

namespace Ryder.Application.Payment.Query
{
    public class VerifyPaymentQuery : IRequest<IResult<VerifyPaymentResponse>>
    {
        public string PaymentReference { get; set; }
        public Guid OrderId { get; set; }
    }

    public class VerifyPaymentQueryValidator : AbstractValidator<VerifyPaymentQuery>
    {
        public VerifyPaymentQueryValidator()
        {
            RuleFor(x => x.PaymentReference).NotNull().NotEmpty();
            RuleFor(x => x.OrderId).NotNull().NotEmpty().WithMessage("Order ID not found");
        }
    }
}
