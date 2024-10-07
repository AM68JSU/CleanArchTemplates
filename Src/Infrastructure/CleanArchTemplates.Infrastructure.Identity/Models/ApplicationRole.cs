using Microsoft.AspNetCore.Identity;
using System;

namespace CleanArchTemplates.Infrastructure.Identity.Models
{
    public class ApplicationRole(string name) : IdentityRole<Guid>(name)
    {
    }
}
