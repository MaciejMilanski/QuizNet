using System.Linq;
using System.Collections.Generic;

using QuizNet.BusinessLogic.DTO;



namespace QuizNet.Models
{
    public class QuestionFormViewModel
    {
        public QuestionFormViewModel(QuestionsDto question, List<AnswersDto> answers)
        {
            Question = question;
            Answers = answers;
            CorrectAnswerId = Answers.FindIndex(x => x.IS_CORRECT);
        }
        public QuestionFormViewModel()
        {
            Question = new QuestionsDto();
            Answers = new List<AnswersDto>();
            for(int i = 0; i < 4; i++)
                Answers.Add(null);
        }
        public QuestionsDto Question { get; set; }
        public List<AnswersDto> Answers { get; set; }
        public int CorrectAnswerId { get; set; }
        public int QuestionId { get; set; }

        public string ActionType
        {
            get
            {
                if (Question.QID == 0)
                    return "Create";
                else
                    return "Edit";
            }
        }
    }
}