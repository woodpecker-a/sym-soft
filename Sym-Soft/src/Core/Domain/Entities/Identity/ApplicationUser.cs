
using Microsoft.AspNetCore.Identity;
using System;

namespace Domain.Entities.Identity
{
    public class ApplicationUser : IdentityUser<Guid>
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
    }
}
