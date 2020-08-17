using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System;

namespace QuizNet.BusinessLogic.DTO
{
    public class QuestionsDto
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "Please specify question text")]
        [StringLength(300)]
        public string CONTENT { get; set; }
        public DateTime CREATION_TIME { get; set; }
    }
}
