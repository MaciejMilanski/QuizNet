using System;

namespace QuizNet.DataAccess.Models
{
    public class Answers
    {
        public int ID { get; set; }
        public string CONTENT { get; set; }
        public Nullable<int> QUESTION_ID { get; set; }
        public Nullable<short> IS_CORRECT { get; set; }
        public DateTime CREATION_TIME { get; set; }

    }
}
