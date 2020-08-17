using System.Linq;
using QuizNet.DataAccess.Models;
using System.Collections.Generic;


namespace QuizNet.DataAccess
{
    public class QuestionsRepository : IQuestionsRepository
    {
        private readonly DatabaseContext _dbContext;
        public QuestionsRepository(DatabaseContext dbContext)
        {
            _dbContext = dbContext;
        }
        public IEnumerable<Questions> GetAll()
        {
            return _dbContext.Questions.AsEnumerable();
        }
        public Questions GetById(int id)
        {
            return _dbContext.Questions.SingleOrDefault(x => x.ID == id);
        }
        public void AddQuestion(Questions question)
        {
            _dbContext.Questions.Add(question);
            _dbContext.SaveChanges();
        }
        public int UpdateQuestions(Questions question)
        {
            var questionToUpdate = _dbContext.Questions.SingleOrDefault(x => x.ID == question.ID);
            questionToUpdate.CONTENT = question.CONTENT;
            _dbContext.SaveChanges();
            return question.ID;
        }
        public void Delete(int id)
        {
            var questionToDelete = _dbContext.Questions.SingleOrDefault(x => x.ID == id);
            _dbContext.Questions.Remove(questionToDelete);
            _dbContext.SaveChanges();
        }

    }
}
