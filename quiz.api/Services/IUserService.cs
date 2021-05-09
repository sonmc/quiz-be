using quiz.entities;

namespace quiz_be.Services
{
    public interface IUserService : IGeneralService<User>
    {
        User Login(string username, string password);
    }
}
