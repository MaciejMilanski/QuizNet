using System.Collections.Generic;
using System.Collections;
using System.Linq;


namespace QuizNet.DataAccess
{
    public class QuestionsRepository : IQuestionsRepository
    {
        QuizNetDataBaseEntities db = new QuizNetDataBaseEntities();
        public IEnumerable<Questions> GetAll()
        {
            return db.Questions.AsEnumerable();
        }
        public Questions GetById(int id)
        {
            return db.Questions.SingleOrDefault(x => x.QID == id);
        }
        public void AddQuestion(Questions question)
        {
            db.Questions.Add(question);
            db.SaveChanges();
        }
        public int UpdateQuestions(Questions question)
        {
            var questionToUpdate = db.Questions.SingleOrDefault(x => x.QID == question.QID);
            questionToUpdate.CONTENT = question.CONTENT;
            db.SaveChanges();
            return question.QID;
        }
        public void Delete(int id)
        {
            var questionToDelete = db.Questions.SingleOrDefault(x => x.QID == id);
            db.Questions.Remove(questionToDelete);
            db.SaveChanges();
        }

    }
}
