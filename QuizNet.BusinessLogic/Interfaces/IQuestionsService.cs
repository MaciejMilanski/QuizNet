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
        QuestionsDto Add(QuestionsDto questionDto, List<AnswersDto> answersDto);
        void Update(QuestionsDto questionDto, List<AnswersDto> answersDto);
        void Delete(int id);

    }
}
