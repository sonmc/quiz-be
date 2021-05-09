using quiz.entities;
using quiz.repositories; 

namespace quiz.services.ServiceImpl
{
    public class AnswerService : GeneralServiceImpl<Answer, IAnswerRepository>, IAnswerService
    {
    }
}
