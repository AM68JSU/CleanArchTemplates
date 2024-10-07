using CleanArchTemplates.Application.Parameters;

namespace CleanArchTemplates.Application.DTOs.Account.Requests
{
    public class GetAllUsersRequest : PaginationRequestParameter
    {
        public string Name { get; set; }
    }
}
