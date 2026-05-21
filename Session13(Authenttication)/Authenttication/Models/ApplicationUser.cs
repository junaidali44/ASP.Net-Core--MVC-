using Microsoft.AspNetCore.Identity;
namespace Authenttication.Models
{
    public class ApplicationUser: IdentityUser
    {
        public string? City { get; set; }
    }
}
