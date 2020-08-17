using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using QuizNet.DataAccess.Models;
using QuizNet.BusinessLogic.DTO;

namespace QuizNet.BusinessLogic.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap <Answers, AnswersDto>();
            CreateMap <AnswersDto, Answers>();

            CreateMap<Questions, QuestionsDto>();
            CreateMap<QuestionsDto, Questions>();
        }


    }
}
