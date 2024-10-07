using CleanArchTemplates.Application.Wrappers;
using MediatR;

namespace CleanArchTemplates.Application.Features.Products.Commands.DeleteProduct
{
    public class DeleteProductCommand : IRequest<BaseResult>
    {
        public long Id { get; set; }
    }
}
