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
    }
}
