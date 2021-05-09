using quiz.entities;  

namespace quiz.repositories.RepositoryImpl
{
    public class QuestionRepositoryImpl : GeneralRepositoryImpl<Question, DataContext>, IQuestionRepository
    {
        DataContext _dbContext;
        public QuestionRepositoryImpl(DataContext context) : base(context)
        {
            this._dbContext = context;
        } 
    }
}
