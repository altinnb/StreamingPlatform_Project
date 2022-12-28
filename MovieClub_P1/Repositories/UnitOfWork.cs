using MovieClub_P1.Core.Repositories;

namespace MovieClub_P1.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        public IUserRepository User { get; }

        public UnitOfWork(IUserRepository user)
        {
            User = user;
        }
    }
}
