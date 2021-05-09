using quiz.entities;
using System.Linq; 

namespace quiz.repositories.RepositoryImpl
{
    public class UserRepositoryImpl : GeneralRepositoryImpl<User, DataContext>, IUserRepository
    {
        DataContext _dbContext;
        public UserRepositoryImpl(DataContext context) : base(context)
        {
            this._dbContext = context;
        }

        public User Login(string username, string password)
        {
            var user = _dbContext.Users.Where(u => u.UserName.Equals(username) && u.Password.Equals(password)).FirstOrDefault();
            return user;
        }
    }
}
