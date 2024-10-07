using CleanArchTemplates.Application.DTOs.Account.Requests;
using CleanArchTemplates.Application.DTOs.Account.Responses;
using CleanArchTemplates.Application.Wrappers;
using System.Threading.Tasks;

namespace CleanArchTemplates.Application.Interfaces.UserInterfaces
{
    public interface IGetUserServices
    {
        Task<PagedResponse<UserDto>> GetPagedUsers(GetAllUsersRequest model);
    }
}
