using System;
using System.Collections.Generic;
using System.Text;
using QuizNet.DataAccess.Models;

namespace QuizNet.DataAccess
{
    public interface IQuestionRepository
    {
        QuestionsViewModel GetAll();
        QuestionsViewModel GetById(int id);
        void Add(QuestionsViewModel question);
        void Update(QuestionsViewModel updatedQuestion);
        void Delete(int questionId);

    }
}