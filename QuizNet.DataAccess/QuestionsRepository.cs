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

        //public IActionResult Get(int id)
        //{
        //    List<Questions> questionList = db.Questions.ToList();
        //    List<QuestionsViewModel> questionVMList = questionList.Select(x => new QuestionsViewModel
        //    {
        //        QID = x.QID,
        //        CONTENT = x.CONTENT,
        //        ANSWER_CONTENT = x.Answers.CONTENT
        //    }).Where(x => x.QID == id).ToList();

        //    List<Answers> answerList = db.Answers.ToList();
        //    List<AnswersViewModel> answersVMList = answerList.Select(x => new AnswersViewModel
        //    {
        //        AID = x.AID,
        //        CONTENT = x.CONTENT,
        //        QUESTION_ID = x.QUESTION_ID,
        //    }).Where(x => x.QUESTION_ID == id).ToList();

        //    DetailsViewModel detailsVM = new DetailsViewModel();
        //    detailsVM.QuestionsList = questionVMList;
        //    detailsVM.AnswersList = answersVMList;


        //    return View(detailsVM);
        //}
    }
}
