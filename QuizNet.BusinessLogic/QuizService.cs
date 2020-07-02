using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using QuizNet.BusinessLogic.DTO;
using QuizNet.BusinessLogic.Interfaces;
using QuizNet.DataAccess;
using AutoMapper;

namespace QuizNet.BusinessLogic
{
    public class QuizService : IQuizService
    {
        private readonly IQuestionsRepository _questionRepository;
        private readonly IAnswersRepository _answersRepository;
        private readonly IMapper _mapper;

        public QuizService(IQuestionsRepository questionsRepository, IAnswersRepository answersRepository, IMapper mapper)
        {
            _questionRepository = questionsRepository;
            _answersRepository = answersRepository;
            _mapper = mapper;
        }
        public List<DetailsDto> GenerateRandomQuiz()
        {
            List<DetailsDto> quizList = new List<DetailsDto>();

            var questions = _questionRepository.GetAll().ToList();

            foreach (var element in questions)
            {
                DetailsDto detailsDto = new DetailsDto();

                var answers = _answersRepository.GetByQID(element.QID);

                var questionDto = _mapper.Map<QuestionsDto>(element);
                var answersDto = _mapper.Map<List<AnswersDto>>(answers);

                detailsDto.QuestionDetails = questionDto;
                detailsDto.AnswersDetails = answersDto;

                quizList.Add(detailsDto);
            }
            quizList  = quizList.OrderBy(x => Guid.NewGuid()).Take(3).ToList();

            return quizList;
        }
        //public int CheckQuiz(List<DetailsDto> checkList, int[] userAnswers)
        //{
        //    int correctAnswersCount = 0;
        //    for (int i = 0; i < checkList.Count; i++)
        //    {
        //        if (checkList[i].AnswersDetails.SingleOrDefault(x => x.IS_CORRECT).AID == userAnswers[i])
        //            correctAnswersCount++;
        //    }
        //}
    }
}
