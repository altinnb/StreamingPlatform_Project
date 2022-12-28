namespace MovieClub_P1.Core.Repositories
{
    public interface IUnitOfWork
    {
        IUserRepository User { get; }
    }
}
