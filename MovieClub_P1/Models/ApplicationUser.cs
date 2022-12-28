using Microsoft.AspNetCore.Identity;

namespace MovieClub_P1.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
