using System.Threading.Tasks;

namespace CleanArchTemplates.Application.Interfaces
{
    public interface IUnitOfWork
    {
        Task<bool> SaveChangesAsync();
    }
}
