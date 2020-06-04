using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuizNet.DataAccess;

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
    }
}
