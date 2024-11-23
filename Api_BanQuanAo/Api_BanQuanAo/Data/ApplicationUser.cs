using Microsoft.AspNetCore.Identity;

namespace Api_BanQuanAo.Data
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
    }
}
