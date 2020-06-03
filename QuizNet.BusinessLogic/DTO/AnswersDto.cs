using System.ComponentModel.DataAnnotations;

namespace QuizNet.BusinessLogic.DTO
{
    public class AnswersDto
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Please specify answer text")]
        public string CONTENT { get; set; }
        public int QID { get; set; }
    }
}
