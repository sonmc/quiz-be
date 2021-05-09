using quiz.entities;
using quiz_be.Entities;
using quiz_be.Repositories;
using quiz_be.Repositories.RepositoryImpl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace quiz_api.Repositories.RepositoryImpl
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
