using CleanArchTemplates.Application.Wrappers;
using CleanArchTemplates.Domain.Products.DTOs;
using MediatR;

namespace CleanArchTemplates.Application.Features.Products.Queries.GetProductById
{
    public class GetProductByIdQuery : IRequest<BaseResult<ProductDto>>
    {
        public long Id { get; set; }
    }
}
