using quiz.entities; 
namespace quiz.repositories.RepositoryImpl
{
    public class ExamRepositoryImpl : GeneralRepositoryImpl<Exam, DataContext>, IExamRepository
    {
        DataContext _dbContext;
        public ExamRepositoryImpl(DataContext context) : base(context)
        {
            this._dbContext = context;
        }
    }
}
