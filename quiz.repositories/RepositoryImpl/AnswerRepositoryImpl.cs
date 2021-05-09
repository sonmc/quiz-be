using quiz.entities; 

namespace quiz.repositories.RepositoryImpl
{
    public class AnswerRepositoryImpl : GeneralRepositoryImpl<Answer, DataContext>, IAnswerRepository
    {
        DataContext _dbContext;
        public AnswerRepositoryImpl(DataContext context) : base(context)
        {
            this._dbContext = context;
        }
    }
}
