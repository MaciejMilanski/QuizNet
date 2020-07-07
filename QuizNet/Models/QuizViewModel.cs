using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using QuizNet.BusinessLogic.DTO;
using System.ComponentModel.DataAnnotations;

namespace QuizNet.Models
{
    public class QuizViewModel
    {
        public QuizViewModel()
        {
        }

        public QuizViewModel(List<DetailsDto> questions, string quizType)
        {
            QuestionAnswers = questions;
            UserAnswerIds = new int[QuestionAnswers.Count];
            QuizType = quizType;
        }
        public List<DetailsDto> QuestionAnswers { get; set; }
        public int[] UserAnswerIds { get; set; }
        public string QuizType { get; set; }
    }
}
