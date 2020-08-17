using System.Collections.Generic;
using QuizNet.DataAccess.Models;

namespace QuizNet.DataAccess
{
    public interface IQuestionsRepository
    {
        IEnumerable<Questions> GetAll();
        Questions GetById( int id);
        void AddQuestion(Questions question);
        int UpdateQuestions(Questions question);
        void Delete(int id);
    }
}