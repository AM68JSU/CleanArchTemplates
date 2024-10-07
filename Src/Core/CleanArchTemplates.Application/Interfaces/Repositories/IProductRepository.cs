using CleanArchTemplates.Application.DTOs;
using CleanArchTemplates.Domain.Products.DTOs;
using CleanArchTemplates.Domain.Products.Entities;
using System.Threading.Tasks;

namespace CleanArchTemplates.Application.Interfaces.Repositories
{
    public interface IProductRepository : IGenericRepository<Product>
    {
        Task<PaginationResponseDto<ProductDto>> GetPagedListAsync(int pageNumber, int pageSize, string name);
    }
}
