using System;
using System.Collections.Generic;
using System.Text;

namespace QuizNet.BusinessLogic.DTO
{
    public class DetailsDto
    {
        public QuestionsDto QuestionDetails { get; set; }
        public List<AnswersDto> AnswersDetails { get; set; }
    }
}
