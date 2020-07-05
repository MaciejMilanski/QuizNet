using System;
using System.Collections.Generic;
using System.Text;
using QuizNet.BusinessLogic.DTO;

namespace QuizNet.BusinessLogic.Interfaces
{
    public interface IQuizService
    {
        List<DetailsDto> GenerateRandomQuiz();
        int CheckQuiz(List<DetailsDto> checkList, int[] userAnswers);
    }
}
