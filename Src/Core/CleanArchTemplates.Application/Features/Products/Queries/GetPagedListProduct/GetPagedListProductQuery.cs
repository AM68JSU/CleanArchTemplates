using CleanArchTemplates.Application.Parameters;
using CleanArchTemplates.Application.Wrappers;
using CleanArchTemplates.Domain.Products.DTOs;
using MediatR;

namespace CleanArchTemplates.Application.Features.Products.Queries.GetPagedListProduct
{
    public class GetPagedListProductQuery : PaginationRequestParameter, IRequest<PagedResponse<ProductDto>>
    {
        public string Name { get; set; }
    }
}
