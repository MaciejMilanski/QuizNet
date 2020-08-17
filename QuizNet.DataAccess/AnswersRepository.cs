using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using QuizNet.DataAccess.Models;
using System.Text;
using System.Threading.Tasks;

namespace QuizNet.DataAccess
{
    public class AnswersRepository :IAnswersRepository
    {
        private readonly DatabaseContext _dbContext;
        public AnswersRepository(DatabaseContext dbContext) 
        {
            _dbContext = dbContext;
        }
        public IEnumerable<Answers> GetByQID( int id )
        {
            return _dbContext.Answers.Where(x => x.QUESTION_ID == id).AsEnumerable();
        }
        public void AddAnswers(List<Answers> answers)
        {
            _dbContext.Answers.AddRange(answers);
            _dbContext.SaveChanges();
        }
        public void UpdateAnswers(List<Answers> answers, int questionId)
        {
            var answersToUpdate = _dbContext.Answers.Where(x => x.QUESTION_ID == questionId).ToList();
            for (int i = 0; i < answersToUpdate.Count; i++)
            {
                answersToUpdate[i].CONTENT = answers[i].CONTENT;
                answersToUpdate[i].IS_CORRECT = answers[i].IS_CORRECT;
            }
            _dbContext.SaveChanges();
        }
        public void Delete(int id)
        {
            var answersToDelete = _dbContext.Answers.Where(x => x.QUESTION_ID == id).ToList();
            _dbContext.Answers.RemoveRange(answersToDelete);
            _dbContext.SaveChanges();
        }
    }
}
