using System;
using System.Collections.Generic;
using System.Text;
using QuizNet.BusinessLogic.DTO;

namespace QuizNet.BusinessLogic.Interfaces
{
    public interface IQuestionsService
    {
        List<QuestionsDto> GetAll();
        DetailsDto GetDetails(int id);
        QuestionsDto AddQuestion(QuestionsDto questionDto);

    }
}
