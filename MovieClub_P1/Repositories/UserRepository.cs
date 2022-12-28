using Microsoft.AspNetCore.Identity;
using MovieClub_P1.Core.Repositories;
using MovieClub_P1.Data;
using MovieClub_P1.Models;

namespace MovieClub_P1.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly ApplicationDbContext _context;
        public UserRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public ICollection<IdentityUser> GetUsers()
        {
            return _context.Users.ToList();
        }
    }
}
