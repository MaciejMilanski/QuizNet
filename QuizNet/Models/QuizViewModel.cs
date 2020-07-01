using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using QuizNet.BusinessLogic.DTO;

namespace QuizNet.Models
{
    public class QuizViewModel
    {
        public QuizViewModel()
        {

        }

        public QuizViewModel(List<DetailsDto> questions)
        {
            QuestionAnswers = questions;
            UserAnswerIds = new int[QuestionAnswers.Count];
        }
        public List<DetailsDto> QuestionAnswers { get; set; }
        public int[] UserAnswerIds { get; set; }
    }
}
