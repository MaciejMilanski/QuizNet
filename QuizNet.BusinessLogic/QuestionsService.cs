using System;
using System.Collections.Generic;
using System.Text;
using QuizNet.BusinessLogic.DTO;
using QuizNet.BusinessLogic.Interfaces;
using QuizNet.DataAccess;
using AutoMapper;

namespace QuizNet.BusinessLogic
{
    public class QuestionsService : IQuestionsService
    {
        private readonly IQuestionsRepository _questionRepository;
        private readonly IMapper _mapper;

        public QuestionsService(IQuestionsRepository questionsRepository, IMapper mapper)
        {
            _questionRepository = questionsRepository;
            _mapper = mapper;
        }

        public List<QuestionsDto> GetAll()
        {
            var questions = _questionRepository.GetAll();
            var questionsDto = _mapper.Map<List<QuestionsDto>>(questions);
            return questionsDto; 
        }
    }
}
