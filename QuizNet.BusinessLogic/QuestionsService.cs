using System;
﻿using System.Collections.Generic;
using AutoMapper;
using QuizNet.BusinessLogic.DTO;
using QuizNet.BusinessLogic.Interfaces;
using QuizNet.DataAccess.Models;
using QuizNet.DataAccess;

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
            var questionDto = _mapper.Map<QuestionsDto>(question);

            var answers = _answersRepository.GetByQID(id);
            var answersDto = _mapper.Map<List<AnswersDto>>(answers);

            DetailsDto detailsDto = new DetailsDto();
            detailsDto.QuestionDetails = questionDto;
            detailsDto.AnswersDetails = answersDto;

            return detailsDto;
        }
        public QuestionsDto Add(QuestionsDto questionDto, List<AnswersDto> answersDto)
        {
            var question = _mapper.Map<Questions>(questionDto);
            question.CREATION_TIME = DateTime.Now;
            _questionRepository.AddQuestion(question);

            var answers = _mapper.Map<List<Answers>>(answersDto);
            for (int i = 0; i < answers.Count; i++)
            {
                answers[i].QUESTION_ID = question.ID;
                answers[i].CREATION_TIME = DateTime.Now;
            }
			
            _answersRepository.AddAnswers(answers);

            var createdQuestion = _mapper.Map<QuestionsDto>(question);
            return createdQuestion;
        }
        public void Update(QuestionsDto questionDto, List<AnswersDto> answersDto)
        {
            var question = _mapper.Map<Questions>(questionDto);
            int questionId = _questionRepository.UpdateQuestions(question);

            var answers = _mapper.Map<List<Answers>>(answersDto);
            _answersRepository.UpdateAnswers(answers, questionId);
        }
        public void Delete(int id)
        {
            _questionRepository.Delete(id);
            _answersRepository.Delete(id);
        }

    }
}
