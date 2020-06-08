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
        public IEnumerable<Questions> GetById(int id)
        {
            return db.Questions.Where(x => x.QID == id).AsEnumerable();
        }
    }
}
