using quiz.entities;

namespace quiz.repositories
{
    public interface IUserRepository : IGeneralRepository<User>
    {
        User Login(string username, string password);
    }
}
