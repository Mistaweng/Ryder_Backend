using AspNetCoreHero.Results;
using FluentValidation;
using MediatR;
using Ryder.Application.User.Query.GetUserInfo;

namespace Ryder.Application.Order.Query.GetAllOrder
{
    public class GetAllOrderQuery : IRequest<IResult<List<Domain.Entities.Order>>>
    {
        public Guid AppUserId { get; set; }
        public int Page { get; set; }
        public int PageSize { get; set; }

        public GetAllOrderQuery(Guid appUserId, int page, int pageSize)
        {
            AppUserId= appUserId;
            Page = page;
            PageSize = pageSize;
        }
    }


    public class GetAllOrderQueryValidator : AbstractValidator<GetAllOrderQuery>
    {
        public GetAllOrderQueryValidator()
        {
            RuleFor(x => x.AppUserId).NotNull().NotEmpty(); 
            RuleFor(x => x.Page).NotEmpty().NotNull();
            RuleFor(x => x.PageSize).NotEmpty().NotNull();
        }
    }
}
