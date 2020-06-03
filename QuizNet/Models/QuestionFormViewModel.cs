using System.Linq;
using QuizNet.BusinessLogic.DTO;

namespace QuizNet.Models
{
    public class QuestionFormViewModel
    {
        public QuestionFormViewModel(QuestionsDto question)
        {
            Question = question;
            //CorrectAnswerIndex = Question.Answers.ToList().FindIndex(a => a.IsCorrect);
        }
        public QuestionFormViewModel()
        {
            Question = new QuestionsDto();
        }
        public QuestionsDto Question { get; set; }
        public int CorrectAnswerIndex { get; set; }

        //public string ActionType
        //{
            //get
            //{
            //    if (Question.Id == 0)
            //        return "Create";
            //    else
            //        return "Edit";
            //}
        //}
    }
}