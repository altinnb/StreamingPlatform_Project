using Microsoft.AspNetCore.Identity;
using MovieClub_P1.Models;

namespace MovieClub_P1.Core.Repositories
{
    public interface IUserRepository
    {
        ICollection<IdentityUser> GetUsers();
    }
}
