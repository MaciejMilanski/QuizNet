using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using QuizNet.BusinessLogic.DTO;

namespace QuizNet.Models
{
    public class QuizSummaryViewModel
    {
        public List<DetailsDto> Questions { get; set; }
        public int[] UserAnswerIds { get; set; }
        public int CorrectAnswers { get; set; }
        public double PercentageCorrect => 100 * (double)CorrectAnswers / Questions.Count;

        public string SummaryText
        {
            get
            {
                if (PercentageCorrect > 50)
                {
                    return "Well done!";
                }
                else
                {
                    return "Shame on you!";
                }
            }
        }

        public string ProgressBarColor
        {
            get
            {
                if (PercentageCorrect > 50)
                {
                    return "bg-success";
                }
                else
                {
                    return "bg-danger";
                }

            }
        }

        public string ClassNamesForAnswer(AnswersDto answer, int userAnswerIndex)
        {
            if (answer.IS_CORRECT)
            {
                return "list-group-item-success";
            }
            else if (UserAnswerIds[userAnswerIndex] == answer.ID)
            {
                return "list-group-item-danger";
            }

            return "";
        }
    }
}
