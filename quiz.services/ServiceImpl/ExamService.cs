using quiz.entities;
using quiz.repositories;

namespace quiz.services.ServiceImpl
{
    public class ExamService : GeneralServiceImpl<Exam, IExamRepository>, IExamService
    {
    }
}
