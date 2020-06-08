using System.Collections.Generic;
using QuizNet.BusinessLogic.DTO;
using QuizNet.BusinessLogic.Interfaces;
using QuizNet.DataAccess;
using AutoMapper;

namespace QuizNet.BusinessLogic
{
    public class QuestionsService : IQuestionsService
    {
        private readonly IQuestionsRepository _questionRepository;
        private readonly IAnswersRepository _answersRepository;
        private readonly IMapper _mapper;

        public QuestionsService(IQuestionsRepository questionsRepository,IAnswersRepository answersRepository, IMapper mapper)
        {
            _questionRepository = questionsRepository;
            _answersRepository = answersRepository;
            _mapper = mapper;
        }

        public List<QuestionsDto> GetAll()
        {
            var questions = _questionRepository.GetAll();
            var questionsDto = _mapper.Map<List<QuestionsDto>>(questions);
            return questionsDto; 
        }

        public DetailsDto GetDetails(int id)
        {
            var question = _questionRepository.GetById(id);
            var questionDto = _mapper.Map<List<QuestionsDto>>(question);

            var answers = _answersRepository.GetByQID(id);
            var answersDto = _mapper.Map<List<AnswersDto>>(answers);

            DetailsDto detailsDto = new DetailsDto();
            detailsDto.QuestionDetails = questionDto;
            detailsDto.AnswersDetails = answersDto;

            return detailsDto;
        }

    }
}
