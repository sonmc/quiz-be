using quiz.entities; 

namespace quiz.repositories.RepositoryImpl
{
    public class GroupRepositoryImpl : GeneralRepositoryImpl<Group, DataContext>, IGroupRepository
    {
        DataContext _dbContext;
        public GroupRepositoryImpl(DataContext context) : base(context)
        {
            this._dbContext = context;
        }
    }
}
