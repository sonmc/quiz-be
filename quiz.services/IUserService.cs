using quiz.entities;

namespace quiz.services
{
    public interface IUserService : IGeneralService<User>
    {
        User Login(string username, string password);
    }
}
