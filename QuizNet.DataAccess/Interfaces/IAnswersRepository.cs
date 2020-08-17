using System.Collections.Generic;
using QuizNet.DataAccess.Models;

namespace QuizNet.DataAccess
{
    public interface IAnswersRepository
    {
        IEnumerable<Answers> GetByQID(int id);
        void AddAnswers(List<Answers> answers);
        void UpdateAnswers(List<Answers> answers, int questionId);
        void Delete(int id);
    }
}
