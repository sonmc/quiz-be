using quiz.entities;
using quiz.repositories;

namespace quiz.services.ServiceImpl
{
    public class QuestionService : GeneralServiceImpl<Question, IQuestionRepository>, IQuestionService
    {
    }
}
