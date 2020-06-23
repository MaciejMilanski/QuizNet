using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizNet.DataAccess
{
    public class AnswersRepository :IAnswersRepository
    {
        QuizNetDataBaseEntities db = new QuizNetDataBaseEntities();
        public IEnumerable<Answers> GetByQID( int id )
        {
            return db.Answers.Where(x => x.QUESTION_ID == id).AsEnumerable();
        }
        public void AddAnswers(List<Answers> answers)
        {
            db.Answers.AddRange(answers);
            db.SaveChanges();
        }
        public void UpdateAnswers(List<Answers> answers, int questionId)
        {
            var answersToUpdate = db.Answers.Where(x => x.QUESTION_ID == questionId).ToList();
            for (int i = 0; i < answersToUpdate.Count; i++)
            {
                answersToUpdate[i].CONTENT = answers[i].CONTENT;
                answersToUpdate[i].IS_CORRECT = answers[i].IS_CORRECT;
            }
            db.SaveChanges();
        }
        public void Delete(int id)
        {
            var answersToDelete = db.Answers.Where(x => x.QUESTION_ID == id).ToList();
            db.Answers.RemoveRange(answersToDelete);
            db.SaveChanges();
        }
    }
}
