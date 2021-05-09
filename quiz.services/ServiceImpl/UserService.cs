 
using quiz.entities; 
using quiz.repositories;  

namespace quiz.services.ServiceImpl
{
    public class UserService : GeneralServiceImpl<User, IUserRepository>, IUserService
    {
        IUserRepository _repository;
 
        public UserService() { }
        public UserService(IUserRepository repository) : base(repository)
        {
            _repository = repository; 
        }
        public User Login(string username, string password)
        {
            var user = _repository.Login(username, password); 
            return user;
        }
    }
}
