using System.Collections.Generic;

namespace QuizNet.DataAccess
{
    public interface IQuestionsRepository
    {
        IEnumerable<Questions> GetAll();
        IEnumerable<Questions> GetById( int id);
        void AddQuestion(Questions question);
    }
}