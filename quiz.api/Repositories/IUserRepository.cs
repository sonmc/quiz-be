using quiz.entities;

namespace quiz_be.Repositories
{
    public interface IUserRepository : IGeneralRepository<User>
    {
        User Login(string username, string password);
    }
}
