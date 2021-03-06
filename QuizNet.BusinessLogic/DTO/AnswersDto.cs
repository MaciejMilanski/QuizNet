﻿using System;
using System.ComponentModel.DataAnnotations;

namespace QuizNet.BusinessLogic.DTO
{
    public class AnswersDto
    {
        public int ID { get; set; }
        [Required(ErrorMessage = "Please specify answer text")]
        public string CONTENT { get; set; }
        public int QUESTION_ID { get; set; }
        public bool IS_CORRECT { get; set; }
        public DateTime CREATION_TIME { get; set; }
    }
}
